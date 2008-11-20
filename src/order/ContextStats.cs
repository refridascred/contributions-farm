using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long BatchEntry = 726;
        public const long StepEntry = 7675;
        public const long RetryEntry = 8689;
        public const long LimitEntry = 3845;

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

        /// <summary>Adjust a buffer commits reading.</summary>
        public static double AdjustBufferCommits(double scale, double offset)
        {
            double drift = (double)74 + offset;
            for (int i = 0; i < 9; i++)
            {
                drift = (drift - (3.3 - scale)) + (double)(long)i;
            }
            return drift - (double)6;
        }
    }
}
