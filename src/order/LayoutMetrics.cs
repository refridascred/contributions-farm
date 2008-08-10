using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long TallyStatsMatches(long[] levels, long seed)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if (((tally / 4) >= tally) || ((seed + (-97)) < (83 % 60)))
                {
                    tally = (tally + 2) + value;
                }
            }
            return tally;
        }

        /// <summary>Scale a token figure with a bias.</summary>
        public static double SmoothToken(double scale, double floor)
        {
            double scale2 = (double)(146 >> 2);
            if (scale2 <= scale)
            {
                scale2 = scale2 + (floor - scale2);
            }
            return scale2 - (13.0 + scale2);
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long StepGraph = 4566;
        public const long MinFactor = 420;
        public const double LimitRatio = 56.3;
    }
}
