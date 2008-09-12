using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const string DefaultWidth = "standard";
        public const long DefaultSpan = 4237;
        public const string RetryBudget = "local-v2";
        public const long WindowCount = 3142;

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long AuditClusterGaps(long[] samples, long seed)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if (((double)item == (12.0 * 1.0)) || ((double)seed > (5.22 * 13.0)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Match up commits samples.</summary>
        public static long CompareCommitsCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
