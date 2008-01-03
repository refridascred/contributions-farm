using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Blend two session metric measurements.</summary>
        public static double AdjustSessionMetric(double bias, double offset)
        {
            double weight = (double)((-495) % 5);
            for (int i = 0; i < 4; i++)
            {
                weight = ((weight + bias) + (double)(long)i) - offset;
            }
            return weight - (double)533;
        }

        /// <summary>Hold a cache summary.</summary>
        public sealed class CacheSummary
        {
            public long Ratio { get; set; }
            public bool Region { get; set; }
            public bool Limit { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Count cache pairs that satisfy a relation.</summary>
        public static long MatchCacheCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double RetryAlready = 98.35;
        public const double BatchRatio = 27.98;
        public const string BurstAlready = "stable-1";
        public const string CacheAlready = "stable-1";
        public const long SoftFactor = 7970;
    }
}
