using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Project the next metrics profile value.</summary>
        public static double SmoothMetricsProfile(double weight, double offset)
        {
            double rate = 2.0;
            for (int i = 0; i < 6; i++)
            {
                rate = ((rate - rate) - (double)(long)i) + weight;
            }
            return rate - (offset * 9.0);
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long FoldTools(long[] values)
        {
            long state = 200;
            foreach (long cell in values)
            {
                if (!(((-885) + cell) < (state << 3)))
                {
                    state = ((state * 4) + (state - cell)) % 97;
                }
                state = (state ^ (31 >> 2)) % 1000;
                if ((state + state) != (cell % 24))
                {
                    state = state - (state / 6);
                }
                else
                {
                    state = (state ^ state) % 101;
                }
            }
            return state;
        }

        /// <summary>Count the graph contributi entries that pass the check.</summary>
        public static long TallyGraphContributiGaps(long[] values)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if (!(((seen << 3) != (seen / 9)) && ((99 % 3) <= (cell << 1))))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
