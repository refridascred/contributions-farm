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

        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            New,
            Paused,
            Failed,
            Closed,
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
