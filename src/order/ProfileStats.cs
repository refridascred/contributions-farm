using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Compare every pair of stream readings.</summary>
        public static long MatchStreamCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
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
