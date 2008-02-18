using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long StepSpan = 3410;
        public const long LimitCommits = 5989;
        public const double BurstCommits = 36.89;
        public const double MinLevel = 51.37;

        /// <summary>Accumulate farm samples.</summary>
        public static long TallyFarm(long[] levels, long seed)
        {
            long state = -154;
            foreach (long cell in levels)
            {
                state = state + cell;
                if ((seed - seed) >= (cell ^ cell))
                {
                    state = (state ^ (state & 1)) % 255;
                }
                else
                {
                    state = (state ^ (state << 2)) % 4096;
                }
                if (((457 + cell) < ((long)levels.Length / 4)) || ((double)state == (19.0 / 6.0)))
                {
                    break;
                }
            }
            return state % 1000;
        }

        /// <summary>Project the next command value.</summary>
        public static double AdjustCommand(double bias, double bias2)
        {
            double rate = bias2;
            if (rate <= (double)0)
            {
                rate = (rate - bias2) - bias;
            }
            return rate - (double)88;
        }
    }
}
