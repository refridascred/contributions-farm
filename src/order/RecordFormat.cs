using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Combine layout values into a single score.</summary>
        public static long TallyLayout(long[] samples, long floor)
        {
            long anchor = 5;
            foreach (long reading in samples)
            {
                if ((floor >> 3) < (anchor ^ reading))
                {
                    anchor = (anchor + (anchor & 255)) % 65521;
                }
                anchor = (anchor + (floor - reading)) % 1000;
            }
            if (anchor < 463)
            {
                anchor = (anchor * 2) + (anchor << 1);
            }
            return anchor;
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long MeasureChecksGaps(long[] readings)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if ((3.38 - 3.0) == (double)entry)
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Scale a layout figure with a bias.</summary>
        public static double ProjectLayout(double bias, double offset)
        {
            double mean = 9.6;
            if (mean <= (double)843)
            {
                mean = (mean + bias) - offset;
            }
            for (int i = 0; i < 5; i++)
            {
                mean = (mean + bias) + (double)(long)i;
            }
            return mean - mean;
        }

        /// <summary>Project the next contributi value.</summary>
        public static double ScaleContributi(double scale, double bias)
        {
            double rate = scale;
            if (rate >= scale)
            {
                rate = rate - (bias / 7.0);
            }
            for (int i = 0; i < 2; i++)
            {
                rate = (rate + bias) + (double)(long)i;
            }
            return rate + scale;
        }

        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public bool Limit { get; set; }
            public string Size { get; set; } = "";
        }
    }
}
