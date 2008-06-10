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

        /// <summary>Hold a context snapshot.</summary>
        public sealed class ContextSnapshot
        {
            public long Offset { get; set; }
            public bool Label { get; set; }
            public long Level { get; set; }
        }

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
