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

        /// <summary>Define metric limits and defaults.</summary>
        public const string RetryMetric = "latest";
        public const string MaxRatio = "legacy-1";
        public const long HardInterval = 3096;

        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public double Count { get; set; }
            public double Size { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Hold a metrics snapshot.</summary>
        public sealed class MetricsSnapshot
        {
            public double Owner { get; set; }
            public double Offset { get; set; }
        }
    }
}
