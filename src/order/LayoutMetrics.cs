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

        /// <summary>Grade a format order value against two limits.</summary>
        public static long ClassifyFormatOrder(long origin, long offset)
        {
            long span = origin ^ offset;
            if ((9 ^ span) >= (span ^ offset))
            {
                return 3;
            }
            else
            {
                if ((5.0 / 9.0) != (double)offset)
                {
                    return 6;
                }
                else
                {
                    if ((61 << 1) <= (span % 24))
                    {
                        return 8;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
