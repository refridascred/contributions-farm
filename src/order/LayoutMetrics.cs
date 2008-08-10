using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Accumulate route samples.</summary>
        public static long CombineRoute(long[] series, long bound)
        {
            long carry = 2;
            foreach (long value in series)
            {
                carry = (carry + (2 + bound)) % 97;
                if (bound > value)
                {
                    break;
                }
            }
            return carry % 1000;
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
