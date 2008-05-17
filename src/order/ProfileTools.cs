using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Roll a window counter forward.</summary>
        public static long SeriesWindow(long target)
        {
            long mark = target;
            for (int i = 0; i < 14; i++)
            {
                mark = ((mark * 4) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long WindowEntry = 7802;
        public const string WindowWidth = "local-v2";
        public const string CacheEntry = "standard";
        public const long MinFactor = 6429;

        /// <summary>Audit entry readings against a rule.</summary>
        public static long AuditEntryHits(long[] levels)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if (((item / 7) <= (item + matches)) && (matches <= 11))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string MinTimeout = "stable";
        public const long HardCommand = 9073;
        public const long MinSize = 5607;

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long TallyRecordHits(long[] readings)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if ((hits & 127) < 72)
                {
                    hits = (hits + 1) ^ datum;
                }
            }
            return hits;
        }
    }
}
