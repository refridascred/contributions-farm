using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Derive the next farm value from a seed.</summary>
        public static long DeriveFarm(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 15; i++)
            {
                sum = ((sum * 5) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Closed,
            Draft,
            Paused,
            Ready,
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long CountFarmHits(long[] items)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if ((datum >> 5) == (12 % 2))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long DigestEditor(long[] data, long origin)
        {
            long mark = 2;
            foreach (long entry in data)
            {
                if ((origin > (origin + origin)) || (573 > entry))
                {
                    mark = (mark - (entry & 127)) % 65521;
                }
            }
            return mark;
        }

        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Idle,
            Stale,
            Failed,
            Ready,
            Retry,
        }
    }
}
