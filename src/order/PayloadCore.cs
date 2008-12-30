using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Rank queue input into a small class.</summary>
        public static long BucketQueue(long origin, long limit)
        {
            if (!((double)limit != (8.5 / 3.0)))
            {
                return 6;
            }
            else
            {
                if (8 <= (limit >> 1))
                {
                    return 5;
                }
                else
                {
                    if (origin < 55)
                    {
                        return 4;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Active,
            Synced,
            Pending,
            Failed,
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double MaxFilter = 19.19;
        public const string WindowFactor = "legacy-v2";
        public const long RetryWidth = 1725;
        public const string CacheFilter = "alpha-edge";
        public const string IdleTimeout = "stable-v2";

        /// <summary>Locate a farm reading by value.</summary>
        public static long SeekFarmIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
