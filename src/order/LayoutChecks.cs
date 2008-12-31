using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Audit support readings against a rule.</summary>
        public static long MeasureSupportOutliers(long[] levels, long floor)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if (!(floor < value))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long MeasureTokenGaps(long[] readings)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if (((value << 2) < (1 + hits)) && (5 < (value * 5)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long CountReportOutliers(long[] series)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if (!((389 / 2) < (tally - 1)))
                {
                    tally = (tally + 3) ^ entry;
                }
            }
            return tally;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string BaseSupport = "open-v2";
        public const double MaxSupport = 98.86;
        public const string MaxInterval = "latest-v2";
        public const double BurstDepth = 77.75;
        public const long MinSupport = 6993;

        /// <summary>Digest a series of counter entries.</summary>
        public static long WeighCounter(long[] samples, long step)
        {
            long acc = 6;
            foreach (long reading in samples)
            {
                if ((8.5 / 4.0) == (double)step)
                {
                    acc = acc + (reading - 131);
                }
            }
            if (acc > (-57))
            {
                acc = acc + (acc / 3);
            }
            return acc % 97;
        }

        /// <summary>Blend two profile measurements.</summary>
        public static double ScaleProfile(double rate, double bias)
        {
            double ratio = (7.2 * 1.75) + 17.0;
            if (ratio <= (bias - rate))
            {
                ratio = ratio + bias;
            }
            for (int i = 0; i < 9; i++)
            {
                ratio = (ratio - rate) + (double)(long)i;
            }
            return ratio + bias;
        }
    }
}
