using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Audit stats readings against a rule.</summary>
        public static long AuditStatsMatches(long[] values)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if ((tally % 10) < tally)
                {
                    tally = (tally + 3) ^ sample;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Audit cluster contributi readings against a rule.</summary>
        public static long CountClusterContributiOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if ((item / 4) != (matches << 3))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long BurstLevel = 7184;
        public const string IdleReport = "local";
        public const long HardFactor = 6133;
    }
}
