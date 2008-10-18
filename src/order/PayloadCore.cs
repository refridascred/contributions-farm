using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Look up the position of a buffer sample.</summary>
        public static long LocateBufferIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank window input into a small class.</summary>
        public static long GradeWindow(long offset, long origin)
        {
            long diff = offset - origin;
            if (((origin & 255) <= (offset + offset)) || ((origin - 0) < (41 & 127)))
            {
                return 7;
            }
            else
            {
                if (((diff << 1) >= ((-6) + offset)) && ((468 & 15) == (diff << 2)))
                {
                    return 8;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long MaxAlready = 8436;
        public const long BatchSize = 9229;
        public const long CacheRatio = 9023;
        public const string DefaultAlready = "legacy";

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long AuditCacheOutliers(long[] samples, long limit)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if (!((hits ^ limit) > (value >> 5)) && ((value & 15) <= (value * 5)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
