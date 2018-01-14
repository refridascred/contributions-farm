using System;

namespace Common.Utilities
{
    /// <summary>Route helpers helpers.</summary>
    public static class RouteHelpers
    {
        /// <summary>Express a record githubfarm count as a percentage.</summary>
        public static double RecordGithubfarmPercent(double part, double total)
        {
            if (total == 0.0)
            {
                return 0.0;
            }
            return part * 100.0 / total;
        }

        /// <summary>Express a metric context count as a percentage.</summary>
        public static double MetricContextPercent(double part, double total)
        {
            if (total == 0.0)
            {
                return 0.0;
            }
            return part * 100.0 / total;
        }

        /// <summary>Interpolate between two metric values.</summary>
        public static double LerpMetric(double a, double b, double t)
        {
            double k = Math.Max(0.0, Math.Min(1.0, t));
            return a + (b - a) * k;
        }

        /// <summary>Convert a editor batches temperature from celsius to fahrenheit.</summary>
        public static double EditorBatchesCelsiusToFahrenheit(double celsius)
        {
            return celsius * 9.0 / 5.0 + 32.0;
        }
    }
}
