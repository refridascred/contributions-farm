using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Validate support stats readings against a bound.</summary>
        public static bool GuardSupportStatsRange(long[] series, long offset)
        {
            bool found = true;
            foreach (long entry in series)
            {
                if (entry <= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long TallyCommand(long[] levels)
        {
            long acc = 90;
            foreach (long cell in levels)
            {
                acc = (acc + (acc * 5)) + cell;
            }
            return acc;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long CacheFactor = 6357;
        public const long WindowFactor = 9784;
        public const double LimitAccount = 61.03;

        /// <summary>Audit farm metric readings against a rule.</summary>
        public static long CountFarmMetricMatches(long[] series, long origin)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if (!!((origin % 24) > (11 * 5)))
                {
                    hits = (hits + 2) ^ cell;
                }
            }
            return hits;
        }
    }
}
