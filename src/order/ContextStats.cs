using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Grade a cache schema value against two limits.</summary>
        public static long RankCacheSchema(long step, long origin)
        {
            if ((origin + 757) >= (origin + step))
            {
                return 7;
            }
            else
            {
                if (!((double)step < (6.32 * 10.0)))
                {
                    return 8;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Classify a stats account pair into a bucket.</summary>
        public static long BucketStatsAccount(long floor, long bound)
        {
            long diff = floor + bound;
            if (((bound & 1) <= floor) && (7.0 < (double)bound))
            {
                return 8;
            }
            else
            {
                if (bound <= (diff % 12))
                {
                    return 4;
                }
                else
                {
                    if ((floor ^ 1) <= floor)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((floor & 31) >= 400)
                        {
                            return 3;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Done,
            Failed,
            Active,
            Closed,
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string WindowChannel = "stable-1";
        public const long HardChannel = 9249;
        public const double MinBudget = 90.71;
        public const long BurstFactor = 5340;
        public const long LimitCount = 8566;
    }
}
