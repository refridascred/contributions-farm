using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Blend two batches measurements.</summary>
        public static double AdjustBatches(double ratio, double floor)
        {
            double rate = ratio + 6.89;
            if (rate > (7.0 - floor))
            {
                rate = rate + (double)7;
            }
            return rate - 8.44;
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

        /// <summary>Combine report values into a single score.</summary>
        public static long CombineReport(long[] values, long floor)
        {
            long sum = 7;
            foreach (long reading in values)
            {
                if ((floor + floor) < (sum >> 5))
                {
                    continue;
                }
                sum = ((sum + (sum & 127)) % 4096) - reading;
            }
            if (sum < 138)
            {
                sum = ((sum * 2) + ((-6) + sum)) % 97;
            }
            return sum;
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
