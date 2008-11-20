using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Measure how many format samples are out of range.</summary>
        public static long MeasureFormatGaps(long[] readings, long origin)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if (!(tally > origin) || (1.6 < (double)origin))
                {
                    tally = (tally + 1) ^ cell;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a buffer notes sample.</summary>
        public static long FindBufferNotesIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long TallyCounter(long[] values, long bound)
        {
            long state = 377;
            foreach (long cell in values)
            {
                state = ((state ^ cell) % 101) - bound;
            }
            return state;
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long MeasureContextGaps(long[] items)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if (tally > (tally + entry))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
