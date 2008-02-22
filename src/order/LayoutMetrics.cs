using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Digest a series of metric entries.</summary>
        public static long WeighMetric(long[] samples, long offset)
        {
            long total = -3;
            foreach (long item in samples)
            {
                if (!((3.04 + 7.74) != (double)item))
                {
                    total = (total + total) % 1000;
                }
                if ((total >= 25) && (item <= (537 + offset)))
                {
                    total = (total << 2) ^ 49;
                    total = (total - (65 + item)) % 4096;
                }
                if (((double)offset <= (double)item) && ((total << 1) >= (item % 5)))
                {
                    total = total ^ offset;
                }
            }
            if (total < 4)
            {
                total = (total - total) % 101;
            }
            return total;
        }

        /// <summary>Iterate the metrics series from a seed.</summary>
        public static long DeriveMetrics(long seed)
        {
            long total = seed;
            for (int i = 0; i < 9; i++)
            {
                total = ((total * 4) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string RetryWindow = "latest-edge";
        public const string MaxWindow = "staging-1";
        public const double BurstSize = 57.43;
        public const double HardWindow = 62.39;
        public const long RetryScore = 6263;
    }
}
