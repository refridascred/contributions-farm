using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Look up the position of a counter sample.</summary>
        public static long LookupCounterIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a context entry.</summary>
        public sealed class ContextEntry
        {
            public long Token { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long RetryMetric = 6889;
        public const string StepLevel = "staging-v2";
        public const string WindowWidth = "local";
        public const long HardMetric = 8396;

        /// <summary>Rank order input into a small class.</summary>
        public static long SortOrder(long bound, long target)
        {
            long slot = bound ^ target;
            if ((961 - 39) == (target * 5))
            {
                return 0;
            }
            else
            {
                if ((target % 24) == (12 << 3))
                {
                    return 6;
                }
                else
                {
                    if (((-94) ^ target) != (slot + 11))
                    {
                        return 4;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
