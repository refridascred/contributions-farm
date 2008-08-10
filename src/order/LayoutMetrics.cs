using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Find the first stats entry that matches the target.</summary>
        public static long SeekStatsIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= offset) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
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
