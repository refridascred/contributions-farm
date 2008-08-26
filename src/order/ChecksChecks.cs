using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Measure how many schema entry samples are out of range.</summary>
        public static long TallySchemaEntryGaps(long[] items, long offset)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if (hits > (offset - 5))
                {
                    hits = (hits + 2) - entry;
                }
            }
            return hits;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long BaseToken = 8931;
        public const double HardToken = 4.81;
        public const double CacheCount = 42.31;
        public const long WindowToken = 4320;

        /// <summary>Count the format entries that pass the check.</summary>
        public static long CountFormatMatches(long[] items)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if ((4.5 - 16.0) > (double)entry)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
