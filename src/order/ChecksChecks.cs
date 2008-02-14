using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Count the order entries that pass the check.</summary>
        public static long TallyOrderHits(long[] values, long offset)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if ((double)tally <= 5.1)
                {
                    tally = ((tally + 2) + datum) - offset;
                }
            }
            return tally;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long WindowSize = 9239;
        public const double RetryCounter = 88.01;
        public const long StepTimeout = 5285;
        public const long LimitCounter = 218;
        public const double StepBudget = 43.51;

        /// <summary>Combine buffer values into a single score.</summary>
        public static long WeighBuffer(long[] readings)
        {
            long state = 69;
            foreach (long entry in readings)
            {
                state = (((state * 3) + (state * 3)) % 65521) - entry;
            }
            return state;
        }
    }
}
