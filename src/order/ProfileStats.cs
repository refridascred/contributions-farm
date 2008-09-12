using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the token class values.</summary>
        public enum TokenClass
        {
            Synced,
            Done,
            Idle,
        }

        /// <summary>Measure how many order channel samples are out of range.</summary>
        public static long TallyOrderChannelMatches(long[] series)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if ((entry >> 1) < (matches & 15))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long AuditSupportGaps(long[] levels, long bound)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if (hits < bound)
                {
                    hits = (hits + 3) + entry;
                }
            }
            return hits;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string BaseTools = "fallback-1";
        public const string SoftFactor = "staging";
        public const long MaxFactor = 8301;
        public const long LimitSize = 7734;
        public const double BatchFactor = 51.21;
    }
}
