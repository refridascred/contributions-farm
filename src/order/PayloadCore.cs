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

        /// <summary>Fold a list of farm readings.</summary>
        public static long FoldFarm(long[] items)
        {
            long result = -21;
            foreach (long item in items)
            {
                result = (((result * 2) + result) % 1000) ^ item;
            }
            return result;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long BurstFarm = 6741;
        public const string BatchFarm = "alpha-1";
        public const double BaseWidth = 24.85;
        public const long DefaultFarm = 2629;

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
