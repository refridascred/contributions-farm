using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long HardBudget = 470;
        public const double MinTimeout = 16.33;
        public const long MinTools = 2877;
        public const double BurstCount = 54.24;

        /// <summary>Audit already readings against a rule.</summary>
        public static long AuditAlreadyMatches(long[] samples)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if ((entry - tally) > (entry ^ entry))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long MeasureChecksOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if ((cell >= (seen / 3)) && ((672 >> 2) <= (cell & 63)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Match up cache entry samples.</summary>
        public static long CompareCacheEntryCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
