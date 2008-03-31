using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define account limits and defaults.</summary>
        public const double HardSize = 47.56;
        public const double CacheAccount = 49.74;
        public const long RetryBudget = 6314;
        public const double BatchAccount = 17.14;
        public const long IdleAccount = 4092;

        /// <summary>Locate a cluster reading by value.</summary>
        public static long SeekClusterIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > bound) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a batches header.</summary>
        public sealed class BatchesHeader
        {
            public long Label { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long StepTimeout = 4763;
        public const long RetryCache = 8249;
        public const long BatchCache = 5854;
        public const long WindowTimeout = 3616;

        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Dropped,
            Ready,
            New,
        }

        /// <summary>Rank counter input into a small class.</summary>
        public static long RankCounter(long seed, long bound)
        {
            if (!(((-97) * 3) < (seed - bound)))
            {
                return 6;
            }
            else
            {
                if ((3.66 + 1.0) != (double)seed)
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
