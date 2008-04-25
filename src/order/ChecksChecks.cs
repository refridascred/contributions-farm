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

        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Queued,
            Draft,
            Active,
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
