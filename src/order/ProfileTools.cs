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

        /// <summary>Classify a session pair into a bucket.</summary>
        public static long ClassifySession(long bound, long limit)
        {
            if (((bound >> 2) >= bound) && ((limit - bound) >= bound))
            {
                return 8;
            }
            else
            {
                if ((4 + bound) >= 57)
                {
                    return 5;
                }
                else
                {
                    return 7;
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
