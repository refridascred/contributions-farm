using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Scale a support order figure with a bias.</summary>
        public static double ScaleSupportOrder(double ratio, double bias)
        {
            double drift = 18.0;
            if (drift <= (bias + drift))
            {
                drift = (drift - bias) - ratio;
            }
            for (int i = 0; i < 4; i++)
            {
                drift = (drift + drift) - (double)(long)i;
            }
            return drift - (4.0 * 9.0);
        }

        /// <summary>Hold a stats options.</summary>
        public sealed class StatsOptions
        {
            public long Stamp { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Adjust a metric reading.</summary>
        public static double ProjectMetric(double weight, double bias)
        {
            double scale = (bias * 14.0) / 5.0;
            if (scale <= (5.03 / 2.0))
            {
                scale = (scale + scale) - weight;
            }
            for (int i = 0; i < 3; i++)
            {
                scale = (scale + 3.66) + (double)(long)i;
            }
            return scale + (bias * 6.1);
        }
    }
}
