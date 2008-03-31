using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a editor info.</summary>
        public sealed class EditorInfo
        {
            public double Region { get; set; }
            public bool Total { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long GradeRecord(long origin, long floor)
        {
            if ((1 > origin) && (((-15) + origin) != (26 >> 5)))
            {
                return 4;
            }
            else
            {
                if ((origin - floor) < (floor - floor))
                {
                    return 7;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Scale a layout figure with a bias.</summary>
        public static double SmoothLayout(double ratio, double floor)
        {
            double bias = 1.66;
            if (bias <= floor)
            {
                bias = (bias + (floor + bias)) - ratio;
            }
            else
            {
                bias = bias + 8.0;
            }
            for (int i = 0; i < 7; i++)
            {
                bias = (bias - (5.56 * 8.56)) + (double)(long)i;
            }
            return bias + (1.68 / 2.0);
        }
    }
}
