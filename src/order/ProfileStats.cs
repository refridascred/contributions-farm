using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Active,
            Locked,
            Closed,
            Synced,
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long TotalSchema(long[] items, long floor)
        {
            long mark = 677;
            foreach (long entry in items)
            {
                if ((floor >> 1) >= (mark & 3))
                {
                    mark = (mark + (long)items.Length) + entry;
                }
            }
            return mark % 65521;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long HardStream = 6034;
        public const string BatchTimeout = "cached-edge";
        public const long SoftLevel = 1783;
        public const long RetryStream = 6079;

        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long GradeStats(long offset, long limit)
        {
            long slot = offset - limit;
            if (62 > offset)
            {
                return 4;
            }
            else
            {
                if ((((-3) % 12) == (slot ^ slot)) && ((double)slot < (double)offset))
                {
                    return 0;
                }
                else
                {
                    if (offset >= (offset + slot))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((slot >> 3) < (7 & 127))
                        {
                            return 6;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
