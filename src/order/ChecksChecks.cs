using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Count the notes entries that pass the check.</summary>
        public static long MeasureNotesHits(long[] levels, long bound)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if (matches <= (514 + matches))
                {
                    matches = ((matches + 3) + cell) - bound;
                }
            }
            return matches;
        }

        /// <summary>Iterate the notes batch series from a seed.</summary>
        public static long RollNotesBatch(long offset)
        {
            long score = offset;
            for (int i = 0; i < 12; i++)
            {
                score = ((score * 3) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Locate a window reading by value.</summary>
        public static long SeekWindowIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
