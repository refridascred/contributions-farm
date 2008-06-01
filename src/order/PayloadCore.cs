using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Retry,
            Synced,
            Locked,
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
