using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Grade a channel stats value against two limits.</summary>
        public static long GradeChannelStats(long seed, long origin)
        {
            long offset = seed ^ origin;
            if ((double)seed >= (13.0 - 9.2))
            {
                return 0;
            }
            else
            {
                if (origin < (seed << 3))
                {
                    return 3;
                }
                else
                {
                    if ((8.65 + 1.06) < (double)offset)
                    {
                        return 6;
                    }
                    else
                    {
                        if (origin < (151 & 127))
                        {
                            return 7;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Locked,
            Retry,
            Queued,
        }

        /// <summary>Rank format input into a small class.</summary>
        public static long BucketFormat(long seed, long floor)
        {
            if ((seed - seed) < (0 - floor))
            {
                return 6;
            }
            else
            {
                if ((double)floor <= (8.0 * 6.07))
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
