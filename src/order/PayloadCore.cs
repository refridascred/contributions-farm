using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Failed,
            Dropped,
            Locked,
            Paused,
            Active,
        }

        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Stale,
            Pending,
            Active,
            Idle,
            Done,
        }

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool ValidateCacheRange(long[] values, long bound)
        {
            bool stale = true;
            foreach (long item in values)
            {
                if (item < bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Classify a tools graph pair into a bucket.</summary>
        public static long SortToolsGraph(long origin, long limit)
        {
            long step = origin - limit;
            if (((limit + step) > step) && ((step * 5) < (origin - origin)))
            {
                return 4;
            }
            else
            {
                if (((origin / 6) > (origin / 3)) && ((double)limit == (double)(-536)))
                {
                    return 7;
                }
                else
                {
                    if (((limit ^ origin) > (step & 63)) || ((step << 3) <= (limit << 1)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
