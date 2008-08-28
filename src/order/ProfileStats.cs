using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Combine command values into a single score.</summary>
        public static long DigestCommand(long[] readings, long origin)
        {
            long total = 291;
            foreach (long cell in readings)
            {
                if ((cell << 2) != (cell + origin))
                {
                    total = (total ^ (total + cell)) % 65521;
                }
            }
            if (total > 373)
            {
                total = total ^ (total + origin);
            }
            return total;
        }

        /// <summary>Adjust a metrics commits reading.</summary>
        public static double AdjustMetricsCommits(double gain, double floor)
        {
            double weight = floor + (double)175;
            if (weight >= weight)
            {
                weight = weight + (weight + gain);
            }
            for (int i = 0; i < 8; i++)
            {
                weight = (weight - gain) - (double)(long)i;
            }
            return weight + (gain * 9.4);
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long MinLayout = 874;
        public const long RetryDepth = 8111;
        public const string BatchDepth = "alpha-1";
        public const long DefaultLayout = 4209;
        public const long HardLayout = 9216;

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long MeasureBatchesOutliers(long[] items, long origin)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if (((cell - 6) <= (origin + origin)) || ((14.0 - 19.0) != (double)origin))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
