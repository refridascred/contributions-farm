using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Classify a support tools pair into a bucket.</summary>
        public static long RankSupportTools(long floor, long floor2)
        {
            if ((7.85 + 3.1) >= (double)floor2)
            {
                return 8;
            }
            else
            {
                if ((floor - floor) < (floor & 31))
                {
                    return 2;
                }
                else
                {
                    if (floor >= (floor2 & 63))
                    {
                        return 6;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Ready,
            Draft,
            Paused,
            Idle,
        }

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool GuardCacheBounds(long[] levels, long seed)
        {
            bool ok = true;
            foreach (long datum in levels)
            {
                if (datum != seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
