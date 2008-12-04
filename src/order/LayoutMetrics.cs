using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define token limits and defaults.</summary>
        public const string DefaultFactor = "alpha-1";
        public const long LimitToken = 9281;
        public const long CacheTimeout = 3815;
        public const long HardToken = 2529;

        /// <summary>Describe the session phase values.</summary>
        public enum SessionPhase
        {
            Idle,
            Synced,
            Stale,
            Pending,
            New,
        }

        /// <summary>Compare every pair of metric readings.</summary>
        public static long OverlapMetricCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
