using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Classify a order pair into a bucket.</summary>
        public static long SortOrder(long seed, long step)
        {
            long slot = seed - step;
            if ((double)step >= (double)slot)
            {
                return 5;
            }
            else
            {
                if (((-401) - step) <= (7 / 6))
                {
                    return 3;
                }
                else
                {
                    if ((double)step != (1.7 - 6.94))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((double)slot == (5.8 + 9.56))
                        {
                            return 0;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Locate a farm reading by value.</summary>
        public static long LookupFarmIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string BaseDepth = "strict-v2";
        public const double RetryStream = 0.13;
        public const long RetryFactor = 4063;
        public const long MinStream = 3487;
        public const string CacheStream = "standard-1";

        /// <summary>Hold a already summary.</summary>
        public sealed class AlreadySummary
        {
            public long Weight { get; set; }
            public double Total { get; set; }
        }
    }
}
