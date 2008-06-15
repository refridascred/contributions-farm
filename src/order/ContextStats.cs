using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Look up the position of a stats report sample.</summary>
        public static long LocateStatsReportIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool VerifyToolsLimits(long[] levels, long offset)
        {
            bool valid = true;
            foreach (long item in levels)
            {
                if (item < offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool GuardToolsLimits(long[] levels, long limit)
        {
            bool found = true;
            foreach (long cell in levels)
            {
                if (cell <= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long AuditChecksHits(long[] levels, long seed)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if ((sample << 2) < (hits + sample))
                {
                    hits = (hits + 2) - seed;
                }
            }
            return hits;
        }
    }
}
