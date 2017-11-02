using System;

namespace Common.Utilities
{
    /// <summary>Batch format helpers.</summary>
    public static class BatchFormat
    {
        /// <summary>Interpolate between two context values.</summary>
        public static double LerpContext(double a, double b, double t)
        {
            double k = Math.Max(0.0, Math.Min(1.0, t));
            return a + (b - a) * k;
        }

        /// <summary>Convert a cache temperature from celsius to fahrenheit.</summary>
        public static double CacheCelsiusToFahrenheit(double celsius)
        {
            return celsius * 9.0 / 5.0 + 32.0;
        }

        /// <summary>Interpolate between two batches digest values.</summary>
        public static double LerpBatchesDigest(double a, double b, double t)
        {
            double k = Math.Max(0.0, Math.Min(1.0, t));
            return a + (b - a) * k;
        }
    }
}
