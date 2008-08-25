using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define window limits and defaults.</summary>
        public const string MinTimeout = "stable-1";
        public const string BaseWindow = "staging";
        public const string MinWindow = "open-edge";
        public const long HardCount = 8087;
        public const long WindowBudget = 9241;

        /// <summary>Audit checks readings against a rule.</summary>
        public static long TallyChecksOutliers(long[] items, long bound)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if ((bound + 49) > hits)
                {
                    hits = (hits + 3) - cell;
                }
            }
            return hits;
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long AuditSchemaHits(long[] readings, long floor)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if ((floor > (matches + matches)) || ((datum - matches) > (matches & 31)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
