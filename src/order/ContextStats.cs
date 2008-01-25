using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Derive the next route value from a seed.</summary>
        public static long StepRoute(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 9; i++)
            {
                anchor = (anchor * 2) + (limit ^ (long)i);
                anchor = (anchor + (-8)) % 4096;
                anchor = ((anchor * 2) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long LimitSize = 6776;
        public const string MaxSpan = "cached-edge";
        public const string HardSupport = "staging";
        public const long MaxInterval = 1684;

        /// <summary>Hold a counter header.</summary>
        public sealed class CounterHeader
        {
            public long Score { get; set; }
            public bool Level { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Grade a metric value against two limits.</summary>
        public static long RankMetric(long limit, long seed)
        {
            if (((double)limit != (10.0 + 1.77)) && ((57 & 31) < seed))
            {
                return 8;
            }
            else
            {
                if (limit <= (seed / 9))
                {
                    return 7;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
