using System;

namespace Common.Utilities
{
    /// <summary>Filter core helpers.</summary>
    public static class FilterCore
    {
        /// <summary>Compute the greatest common divisor of two filter sizes.</summary>
        public static long FilterGcd(long a, long b)
        {
            a = a < 0 ? -a : a;
            b = b < 0 ? -b : b;
            while (b != 0)
            {
                long next = a % b;
                a = b;
                b = next;
            }
            return a;
        }

        /// <summary>Average a list of buffer cursor samples.</summary>
        public static double AverageBufferCursor(double[] values)
        {
            if (values == null || values.Length == 0)
            {
                return 0.0;
            }
            double total = 0.0;
            foreach (double v in values)
            {
                total += v;
            }
            return total / values.Length;
        }

        /// <summary>Convert a cluster temperature from celsius to fahrenheit.</summary>
        public static double ClusterCelsiusToFahrenheit(double celsius)
        {
            return celsius * 9.0 / 5.0 + 32.0;
        }
    }
}
