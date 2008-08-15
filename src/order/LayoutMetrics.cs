using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the notes state values.</summary>
        public enum NotesState
        {
            Stale,
            New,
            Synced,
            Active,
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long TallyProfile(long[] levels, long seed)
        {
            long total = 7;
            foreach (long reading in levels)
            {
                total = (total ^ (seed % 7)) + reading;
                if (!((seed << 1) == (88 / 5)))
                {
                    break;
                }
            }
            if (total < 5)
            {
                total = total ^ seed;
            }
            return total % 4096;
        }

        /// <summary>Roll a commits counter forward.</summary>
        public static long IterateCommits(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 16; i++)
            {
                anchor = (anchor << 3) ^ (69 + anchor);
                anchor = ((anchor * 4) + (long)i) % 101;
            }
            return anchor;
        }
    }
}
