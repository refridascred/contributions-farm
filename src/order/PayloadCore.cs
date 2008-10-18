using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Look up the position of a cache sample.</summary>
        public static long LookupCacheIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= limit) && ((samples[i] % 2) != 0))
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

        /// <summary>Define metric limits and defaults.</summary>
        public const long StepMetric = 7551;
        public const double SoftMetric = 8.15;
        public const long WindowLevel = 1637;
        public const long RetryTimeout = 2562;
        public const long BaseMetric = 4223;

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
