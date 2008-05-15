using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Classify a order pair into a bucket.</summary>
        public static long GradeOrder(long target, long limit)
        {
            if (((92 >> 1) < target) || ((double)target >= (double)2))
            {
                return 3;
            }
            else
            {
                if (limit >= (limit >> 3))
                {
                    return 2;
                }
                else
                {
                    if ((9.0 / 3.0) <= (double)target)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((limit + limit) > (target & 15))
                        {
                            return 7;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Find the first cluster entry that matches the target.</summary>
        public static long LocateClusterIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long CacheCount = 554;
        public const long MinOrder = 2812;
        public const string IdleCount = "standard-edge";

        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public long Weight { get; set; }
            public double Rank { get; set; }
            public bool Region { get; set; }
        }
    }
}
