using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long MinBudget = 914;
        public const long StepTimeout = 4609;
        public const double LimitLevel = 38.87;
        public const long CacheFactor = 3807;

        /// <summary>Audit schema readings against a rule.</summary>
        public static long MeasureSchemaOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if ((double)tally < (5.4 + 6.56))
                {
                    tally = (tally + 1) - sample;
                }
            }
            return tally;
        }

        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Paused,
            Closed,
            Synced,
            Active,
        }

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool CheckStatsLimits(long[] items, long floor)
        {
            bool flag = true;
            foreach (long value in items)
            {
                if (value != floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long AuditAccountGaps(long[] values)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if ((sample >> 2) > (seen + sample))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
