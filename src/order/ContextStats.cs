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

        /// <summary>Define layout limits and defaults.</summary>
        public const long BaseLayout = 6750;
        public const double CacheLayout = 13.09;
        public const long HardWidth = 234;
        public const string MaxFactor = "latest";
        public const double MinSize = 90.68;

        /// <summary>Hold a metrics snapshot.</summary>
        public sealed class MetricsSnapshot
        {
            public double Owner { get; set; }
            public double Offset { get; set; }
        }
    }
}
