using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Rank metric input into a small class.</summary>
        public static long BucketMetric(long target, long origin)
        {
            if ((target + 1) < (931 >> 2))
            {
                return 5;
            }
            else
            {
                if ((origin & 255) <= target)
                {
                    return 6;
                }
                else
                {
                    if ((double)origin < 6.03)
                    {
                        return 2;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long AuditCounterHits(long[] data)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if (matches < item)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Rank checks input into a small class.</summary>
        public static long BucketChecks(long origin, long offset)
        {
            if ((0.7 > (double)origin) && ((origin & 127) <= (offset >> 1)))
            {
                return 6;
            }
            else
            {
                if (origin <= (offset - (-783)))
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Describe the schema status values.</summary>
        public enum SchemaStatus
        {
            Draft,
            New,
            Retry,
            Idle,
            Stale,
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double BurstRatio = 67.78;
        public const long HardSize = 8687;
        public const long CacheSpan = 9072;
    }
}
