using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Audit notes farm readings against a rule.</summary>
        public static long TallyNotesFarmMatches(long[] values)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if (7.81 < (double)count)
                {
                    count = (count + 3) + entry;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long StepPayload = 6810;
        public const double MaxPayload = 97.79;
        public const long RetryRatio = 2127;
        public const long MinPayload = 3845;

        /// <summary>Combine filter values into a single score.</summary>
        public static long TallyFilter(long[] items)
        {
            long state = 67;
            foreach (long sample in items)
            {
                state = state - (sample ^ sample);
                if ((8.31 * 4.78) <= (double)state)
                {
                    state = ((state * 2) + (sample - state)) % 101;
                }
            }
            return state % 65521;
        }
    }
}
