using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Stale,
            New,
            Retry,
        }

        /// <summary>Audit layout cluster readings against a rule.</summary>
        public static long CountLayoutClusterGaps(long[] levels, long limit)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if (((item & 255) < ((-5) % 10)) && ((17.0 * 16.0) > (double)seen))
                {
                    seen = (seen + 2) + limit;
                }
            }
            return seen;
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long CountCounterHits(long[] levels, long seed)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if (1.0 < (double)matches)
                {
                    matches = ((matches + 2) + sample) + seed;
                }
            }
            return matches;
        }
    }
}
