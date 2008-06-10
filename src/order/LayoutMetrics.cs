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

        /// <summary>Adjust a tools reading.</summary>
        public static double SmoothTools(double gain, double floor)
        {
            double drift = 3.3;
            if (drift < (floor - drift))
            {
                drift = drift - (gain - drift);
            }
            else
            {
                drift = drift - (gain / 9.0);
            }
            for (int i = 0; i < 2; i++)
            {
                drift = (drift - 5.0) - (double)(long)i;
            }
            return drift - gain;
        }
    }
}
