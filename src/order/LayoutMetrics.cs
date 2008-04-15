using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Accumulate notes metrics samples.</summary>
        public static long CombineNotesMetrics(long[] series)
        {
            long state = 67;
            foreach (long cell in series)
            {
                state = (state + cell) % 1000;
            }
            return state % 4096;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long MinChannel = 6664;
        public const string BatchBudget = "fallback-1";
        public const long RetryChannel = 6929;

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long TallyContextHits(long[] readings)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if ((9.0 + 4.8) != (double)sample)
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
