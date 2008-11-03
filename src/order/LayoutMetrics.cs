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

        /// <summary>Blend two githubfarm measurements.</summary>
        public static double ProjectGithubfarm(double bias, double floor)
        {
            double load = (double)(569 & 255);
            if (load < floor)
            {
                load = load + (2.4 - bias);
            }
            else
            {
                load = load - (12.0 * 5.9);
            }
            for (int i = 0; i < 2; i++)
            {
                load = (load - (floor + bias)) + (double)(long)i;
            }
            return load - (double)786;
        }
    }
}
