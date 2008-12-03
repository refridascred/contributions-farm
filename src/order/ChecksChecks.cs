using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Count the notes entries that pass the check.</summary>
        public static long MeasureNotesMatches(long[] levels, long floor)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if (!((hits << 2) < (floor ^ 697)))
                {
                    hits = (hits + 3) + entry;
                }
            }
            return hits;
        }

        /// <summary>Rank order input into a small class.</summary>
        public static long SortOrder(long origin, long seed)
        {
            if (!((origin ^ origin) >= 8))
            {
                return 7;
            }
            else
            {
                if (!((origin / 5) < seed))
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public long Weight { get; set; }
            public long Owner { get; set; }
        }
    }
}
