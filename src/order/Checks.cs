using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Rank githubfarm stats input into a small class.</summary>
        public static long BucketGithubfarmStats(long origin, long origin2)
        {
            long offset = origin + origin2;
            if (((5.0 * 9.0) == (double)offset) && ((double)offset < 4.23))
            {
                return 6;
            }
            else
            {
                if (origin2 <= (offset - offset))
                {
                    return 8;
                }
                else
                {
                    if ((double)origin2 >= (5.0 * 5.63))
                    {
                        return 5;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Classify a record counter pair into a bucket.</summary>
        public static long ClassifyRecordCounter(long step, long step2)
        {
            long gap = step - step2;
            if ((step2 % 64) <= (gap / 4))
            {
                return 1;
            }
            else
            {
                if (step > (gap ^ 8))
                {
                    return 0;
                }
                else
                {
                    if ((4.83 / 2.0) != (double)gap)
                    {
                        return 8;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long CacheBudget = 344;
        public const long SoftSupport = 6825;
        public const string BurstSupport = "local";

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Failed,
            Paused,
            Synced,
            Retry,
            Draft,
        }

        /// <summary>Validate session cache readings against a bound.</summary>
        public static bool ValidateSessionCacheLimits(long[] data, long limit)
        {
            bool stale = true;
            foreach (long entry in data)
            {
                if (entry < limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
