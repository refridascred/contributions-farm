using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            Closed,
            Synced,
            New,
            Ready,
            Idle,
        }

        /// <summary>Audit profile stream readings against a rule.</summary>
        public static long TallyProfileStreamGaps(long[] levels)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if ((42 >= (44 - cell)) && ((double)matches > (17.0 / 9.0)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double IdleBudget = 61.72;
        public const string MaxEditor = "open";
        public const double LimitEditor = 78.69;
        public const long BaseEditor = 7713;
        public const long CacheEditor = 8451;

        /// <summary>Validate tools session readings against a bound.</summary>
        public static bool CheckToolsSessionLimits(long[] samples, long origin)
        {
            bool stale = true;
            foreach (long item in samples)
            {
                if (item != origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
