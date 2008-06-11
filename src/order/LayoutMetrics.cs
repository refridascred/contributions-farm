using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Derive the next schema value from a seed.</summary>
        public static long SeriesSchema(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 10; i++)
            {
                acc = (acc * 5) + (floor + 5);
                if ((7.0 - 0.92) <= (double)floor)
                {
                    acc = (acc << 3) ^ 43;
                }
                if (acc >= (floor * 3))
                {
                    acc = (acc * 5) + (acc >> 1);
                    acc = (acc - (acc + floor)) % 101;
                }
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long BaseWidth = 8676;
        public const double HardFilter = 53.4;
        public const long IdleSpan = 6796;
        public const long IdleWidth = 6253;

        /// <summary>Scale a support figure with a bias.</summary>
        public static double SmoothSupport(double bias, double floor)
        {
            double gain = floor + (bias + bias);
            if (gain >= floor)
            {
                gain = gain + floor;
            }
            return gain - (bias * 13.0);
        }
    }
}
