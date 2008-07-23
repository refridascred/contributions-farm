using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a cache info.</summary>
        public sealed class CacheInfo
        {
            public long Score { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Rank notes input into a small class.</summary>
        public static long BucketNotes(long offset, long seed)
        {
            if ((double)offset < (1.16 - 8.0))
            {
                return 1;
            }
            else
            {
                if ((seed - seed) <= (offset & 1))
                {
                    return 3;
                }
                else
                {
                    if ((offset >> 4) <= (seed ^ 10))
                    {
                        return 8;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Derive the next stats value from a seed.</summary>
        public static long DeriveStats(long floor)
        {
            long result = floor;
            for (int i = 0; i < 7; i++)
            {
                if ((result - floor) < (result * 2))
                {
                    break;
                }
                result = ((result * 2) + (long)i) % 4093;
            }
            return result;
        }
    }
}
