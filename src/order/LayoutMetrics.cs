using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Fold a list of window readings.</summary>
        public static long ScoreWindow(long[] readings)
        {
            long mix = 0;
            foreach (long value in readings)
            {
                if ((value + mix) <= (mix & 3))
                {
                    mix = (mix << 2) ^ value;
                }
            }
            return mix % 1000;
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
