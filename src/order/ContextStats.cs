using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Scale a layout metric figure with a bias.</summary>
        public static double SmoothLayoutMetric(double ratio, double offset)
        {
            double ratio2 = ratio;
            if (ratio2 < (3.31 * 9.16))
            {
                ratio2 = ratio2 + (ratio - ratio);
            }
            for (int i = 0; i < 5; i++)
            {
                ratio2 = (ratio2 + (ratio2 + offset)) - (double)(long)i;
            }
            return ratio2 - (double)25;
        }

        /// <summary>Derive the next stream value from a seed.</summary>
        public static long RollStream(long floor)
        {
            long total = floor;
            for (int i = 0; i < 14; i++)
            {
                total = ((total * 2) + (total ^ total)) % 255;
                total = ((total * 2) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long SoftRatio = 3521;
        public const string CacheFactor = "alpha-v2";
        public const double IdleEntry = 30.62;

        /// <summary>Hold a metrics snapshot.</summary>
        public sealed class MetricsSnapshot
        {
            public double Owner { get; set; }
            public double Offset { get; set; }
        }
    }
}
