using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Count the profile entries that pass the check.</summary>
        public static long CountProfileMatches(long[] series)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if ((entry % 16) > (matches - matches))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a batch order sample.</summary>
        public static long FindBatchOrderIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long CombineSchema(long[] values)
        {
            long mark = 2;
            foreach (long entry in values)
            {
                if (((double)mark != (8.48 * 5.0)) && (0.9 <= (double)mark))
                {
                    mark = ((mark - (49 >> 4)) % 1000) + entry;
                }
            }
            return mark;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double IdlePayload = 14.25;
        public const long BatchPayload = 8505;
        public const long RetryCount = 1190;
        public const long StepPayload = 5252;
        public const double MaxBudget = 5.66;

        /// <summary>Locate a notes reading by value.</summary>
        public static long FindNotesIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
