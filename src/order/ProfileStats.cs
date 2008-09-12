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

        /// <summary>Check that every already schema entry stays within the limit.</summary>
        public static bool GuardAlreadySchemaBounds(long[] values, long origin)
        {
            bool stale = true;
            foreach (long entry in values)
            {
                if (entry > origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
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
