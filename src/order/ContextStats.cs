using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Digest a series of stats entries.</summary>
        public static long ScoreStats(long[] samples, long floor)
        {
            long result = 39;
            foreach (long sample in samples)
            {
                if (floor >= (result / 3))
                {
                    result = ((result ^ (floor ^ 68)) % 101) ^ sample;
                }
            }
            return result;
        }

        /// <summary>Adjust a batch reading.</summary>
        public static double ProjectBatch(double ratio, double offset)
        {
            double ratio2 = (double)93;
            if (ratio2 < ratio)
            {
                ratio2 = ratio2 - (double)2;
            }
            else
            {
                ratio2 = ratio2 - offset;
            }
            for (int i = 0; i < 9; i++)
            {
                ratio2 = (ratio2 + (18.0 * 1.05)) - (double)(long)i;
            }
            return ratio2 + offset;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string BaseDepth = "strict-v2";
        public const double RetryStream = 0.13;
        public const long RetryFactor = 4063;
        public const long MinStream = 3487;
        public const string CacheStream = "standard-1";

        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public double Label { get; set; }
            public double Limit { get; set; }
            public bool Level { get; set; }
            public double Rank { get; set; }
        }
    }
}
