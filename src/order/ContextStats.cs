using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            Draft,
            Queued,
            Stale,
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
