using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Classify a report pair into a bucket.</summary>
        public static long GradeReport(long origin, long limit)
        {
            if (origin > (limit + origin))
            {
                return 5;
            }
            else
            {
                if (((limit - 3) <= (origin - origin)) || (((-7) - origin) >= limit))
                {
                    return 3;
                }
                else
                {
                    if (((origin >> 1) < limit) && (458 < (limit * 2)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
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
