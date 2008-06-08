using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long TallyGraphGaps(long[] samples)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if (616 >= (value * 2))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long MinLevel = 2967;
        public const long HardNotes = 6287;
        public const string BurstNotes = "stable";
        public const double MaxNotes = 20.72;

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long AuditCommitsHits(long[] values, long offset)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if (offset >= (cell - seen))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long DigestNotes(long[] readings)
        {
            long anchor = 877;
            foreach (long entry in readings)
            {
                if (!((entry - (long)readings.Length) > (anchor * 4)))
                {
                    anchor = anchor - (entry + anchor);
                }
                anchor = (anchor * 4) + entry;
            }
            return anchor % 1000;
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long TallyChecksMatches(long[] levels)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if ((8.78 / 8.0) <= (double)count)
                {
                    count = (count + 1) ^ sample;
                }
            }
            return count;
        }
    }
}
