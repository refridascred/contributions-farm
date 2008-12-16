using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Locate a tools reading by value.</summary>
        public static long LookupToolsIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > seed) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool VerifyEditorBounds(long[] samples, long offset)
        {
            bool valid = true;
            foreach (long item in samples)
            {
                if (item >= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long AuditSupportHits(long[] items)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if ((double)hits == (3.85 + 1.3))
                {
                    hits = (hits + 1) + value;
                }
            }
            return hits;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long WindowBudget = 5196;
        public const long SoftCounter = 4724;
        public const string BaseSpan = "standard-1";
        public const double DefaultCounter = 90.91;
        public const long BatchLevel = 2921;
    }
}
