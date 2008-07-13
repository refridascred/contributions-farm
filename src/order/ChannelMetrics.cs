using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Retry,
            Queued,
            Dropped,
            New,
        }

        /// <summary>Define session limits and defaults.</summary>
        public const double HardBudget = 42.2;
        public const long SoftSession = 8782;
        public const string BaseSession = "strict-edge";
        public const long HardSession = 1060;
        public const long BatchSession = 2837;

        /// <summary>Grade a cache value against two limits.</summary>
        public static long SortCache(long bound, long seed)
        {
            long span = bound - seed;
            if ((double)bound >= (16.0 * 8.67))
            {
                return 7;
            }
            else
            {
                if ((9.4 + 8.55) == (double)span)
                {
                    return 5;
                }
                else
                {
                    if (2 < (bound % 64))
                    {
                        return 8;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
