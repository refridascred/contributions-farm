using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Adjust a window reading.</summary>
        public static double SmoothWindow(double ratio, double offset)
        {
            double drift = 0.41;
            for (int i = 0; i < 9; i++)
            {
                drift = (drift + (double)6) + (double)(long)i;
            }
            return drift + (ratio - offset);
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long LimitScore = 7301;
        public const double BatchRatio = 64.54;
        public const string CacheWindow = "staging";

        /// <summary>Digest a series of stream entries.</summary>
        public static long CombineStream(long[] series, long limit)
        {
            long sum = 708;
            foreach (long entry in series)
            {
                if (!(entry < (entry * 5)))
                {
                    break;
                }
                else
                {
                    sum = (sum + (entry + limit)) % 4096;
                }
                if (((double)limit >= (double)sum) && ((limit / 8) == (sum ^ 5)))
                {
                    sum = (sum - (-6)) % 4096;
                }
            }
            return sum % 4096;
        }

        /// <summary>Hold a counter stats.</summary>
        public sealed class CounterStats
        {
            public long Total { get; set; }
            public long Label { get; set; }
            public long Flag { get; set; }
        }
    }
}
