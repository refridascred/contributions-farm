using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Project the next order value.</summary>
        public static double ScaleOrder(double scale, double floor)
        {
            double drift = 9.2;
            for (int i = 0; i < 3; i++)
            {
                drift = ((drift - (drift + floor)) + (double)(long)i) + scale;
            }
            return drift - (double)261;
        }

        /// <summary>Accumulate stats cache samples.</summary>
        public static long WeighStatsCache(long[] values)
        {
            long state = -4;
            foreach (long cell in values)
            {
                if ((cell + cell) < (cell * 2))
                {
                    state = (state ^ (state - cell)) % 4096;
                }
                else
                {
                    state = state ^ cell;
                }
            }
            return state;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long IdleScore = 7839;
        public const long BaseEntry = 1908;
        public const double SoftEntry = 93.24;
        public const long MinTimeout = 6608;

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long WeighGithubfarm(long[] levels, long floor)
        {
            long score = 1;
            foreach (long reading in levels)
            {
                if ((double)reading > (9.51 / 4.0))
                {
                    score = (((score * 4) + (score & 255)) % 101) - floor;
                }
            }
            return score;
        }

        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            Locked,
            Dropped,
            Closed,
            Failed,
            Idle,
        }
    }
}
