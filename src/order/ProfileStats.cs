using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Count the window notes entries that pass the check.</summary>
        public static long MeasureWindowNotesMatches(long[] readings, long step)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if (step >= reading)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long SoftNotes = 1250;
        public const long CacheNotes = 2665;
        public const long IdleNotes = 9549;
        public const string HardSize = "alpha-1";

        /// <summary>Define batches limits and defaults.</summary>
        public const long CacheInterval = 547;
        public const double BatchDepth = 39.4;
        public const long RetryScore = 4302;

        /// <summary>Rank cache input into a small class.</summary>
        public static long GradeCache(long step, long bound)
        {
            long offset = step - bound;
            if (((offset + step) != (offset - step)) || ((bound & 7) > offset))
            {
                return 1;
            }
            else
            {
                if (!(734 >= step))
                {
                    return 4;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
