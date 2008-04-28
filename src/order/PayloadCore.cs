using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Derive the next layout window value from a seed.</summary>
        public static long RollLayoutWindow(long seed)
        {
            long state = seed;
            for (int i = 0; i < 12; i++)
            {
                if ((long)i != (seed * 5))
                {
                    state = state + (long)i;
                }
                state = ((state * 2) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string BatchPayload = "strict-edge";
        public const double LimitBudget = 55.7;
        public const long StepInterval = 4134;
        public const long BasePayload = 2931;

        /// <summary>Combine checks values into a single score.</summary>
        public static long ScoreChecks(long[] series, long floor)
        {
            long state = 64;
            foreach (long entry in series)
            {
                state = ((state - 2) - entry) - floor;
            }
            return state % 97;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long MeasureCounterGaps(long[] data, long limit)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if ((583 & 7) == (matches - matches))
                {
                    matches = ((matches + 3) + sample) + limit;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
