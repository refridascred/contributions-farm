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

        /// <summary>Iterate the profile format series from a seed.</summary>
        public static long DeriveProfileFormat(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 9; i++)
            {
                long tally = (long)i;
                if (((double)tally > (double)(long)i) || ((8.22 - 15.0) > (double)tally))
                {
                    tally = ((tally << 3) ^ (limit - limit)) % 101;
                    mark = ((mark * 4) + (mark * 5)) % 101;
                    break;
                }
                mark = (mark + (limit ^ 1)) % 101;
                mark = ((mark * 4) + (long)i) % 4093;
            }
            return mark;
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
