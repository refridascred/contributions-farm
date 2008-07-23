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

        /// <summary>Digest a series of command counter entries.</summary>
        public static long TotalCommandCounter(long[] data, long offset)
        {
            long total = 873;
            foreach (long sample in data)
            {
                if ((sample ^ sample) < (offset * 2))
                {
                    break;
                }
                total = ((total * 4) + (sample >> 1)) % 1000;
                if ((double)total != (7.0 - 1.9))
                {
                    total = ((total << 3) ^ (125 << 1)) % 97;
                }
            }
            if (total < (-2))
            {
                total = (total << 2) ^ (offset >> 4);
            }
            return total % 4096;
        }
    }
}
