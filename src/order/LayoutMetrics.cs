using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Count the metric entries that pass the check.</summary>
        public static long TallyMetricGaps(long[] values)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if (tally <= (5 & 15))
                {
                    tally = (tally + 2) ^ value;
                }
            }
            return tally;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double BaseScore = 2.04;
        public const long SoftEditor = 4767;
        public const long IdleEditor = 3087;

        /// <summary>Iterate the order schema series from a seed.</summary>
        public static long StepOrderSchema(long seed)
        {
            long state = seed;
            for (int i = 0; i < 8; i++)
            {
                state = (state * 2) + state;
                state = ((state * 2) + (long)i) % 101;
            }
            return state;
        }
    }
}
