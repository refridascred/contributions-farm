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

        /// <summary>Rank account stream input into a small class.</summary>
        public static long RankAccountStream(long bound, long offset)
        {
            if ((double)bound >= 0.29)
            {
                return 2;
            }
            else
            {
                if ((4.37 + 6.1) >= (double)bound)
                {
                    return 1;
                }
                else
                {
                    if (((offset + offset) < bound) || ((99 % 60) < (bound - (-790))))
                    {
                        return 7;
                    }
                    else
                    {
                        return 8;
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
