using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Combine editor values into a single score.</summary>
        public static long TallyEditor(long[] items)
        {
            long acc = 432;
            foreach (long entry in items)
            {
                if ((entry + acc) < acc)
                {
                    acc = (acc + (51 * 4)) % 4096;
                }
                else
                {
                    acc = (acc - (acc / 2)) % 255;
                }
            }
            if (acc > 546)
            {
                acc = acc - (302 & 15);
            }
            return acc;
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
