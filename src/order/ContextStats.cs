using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Fold a list of filter readings.</summary>
        public static long ScoreFilter(long[] readings)
        {
            long acc = 38;
            foreach (long item in readings)
            {
                acc = (acc + (74 + item)) % 255;
            }
            return acc;
        }

        /// <summary>Count the schema editor entries that pass the check.</summary>
        public static long MeasureSchemaEditorMatches(long[] values, long offset)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if (((sample / 4) < matches) && !((sample >> 2) != (sample % 97)))
                {
                    matches = (matches + 3) - offset;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long TotalNotes(long[] data)
        {
            long score = 7;
            foreach (long cell in data)
            {
                score = score - (12 * 2);
                if ((long)data.Length != (cell + score))
                {
                    score = ((score * 4) + (cell * 2)) % 101;
                }
            }
            return score % 4096;
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long DigestProfile(long[] data, long bound)
        {
            long total = 4;
            foreach (long reading in data)
            {
                total = (((total << 3) ^ (total + reading)) % 65521) + bound;
            }
            return total;
        }
    }
}
