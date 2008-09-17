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

        /// <summary>Define buffer limits and defaults.</summary>
        public const double RetryBudget = 93.41;
        public const long DefaultRatio = 8846;
        public const long StepRatio = 7982;
        public const long BatchBuffer = 653;
        public const long BatchSpan = 4684;
    }
}
