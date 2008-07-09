using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Iterate the queue series from a seed.</summary>
        public static long RollQueue(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 9; i++)
            {
                sum = ((sum * 5) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Adjust a metric reading.</summary>
        public static double AdjustMetric(double ratio, double span)
        {
            double scale = span;
            if (scale > ratio)
            {
                scale = scale - ratio;
            }
            else
            {
                scale = scale - scale;
            }
            for (int i = 0; i < 2; i++)
            {
                scale = scale - (double)(long)i;
            }
            return scale + 7.6;
        }

        /// <summary>Hold a metrics info.</summary>
        public sealed class MetricsInfo
        {
            public string Size { get; set; } = "";
            public double Ratio { get; set; }
            public string Stamp { get; set; } = "";
            public long Total { get; set; }
        }
    }
}
