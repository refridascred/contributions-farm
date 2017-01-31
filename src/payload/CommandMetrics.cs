using System;

namespace Common.Utilities
{
    /// <summary>Command metrics helpers.</summary>
    public static class CommandMetrics
    {
        /// <summary>Compute the greatest common divisor of two layout sizes.</summary>
        public static long LayoutGcd(long a, long b)
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

        /// <summary>Compute the greatest common divisor of two catalog sizes.</summary>
        public static long CatalogGcd(long a, long b)
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

        /// <summary>Convert a batches temperature from celsius to fahrenheit.</summary>
        public static double BatchesCelsiusToFahrenheit(double celsius)
        {
            return celsius * 9.0 / 5.0 + 32.0;
        }

        /// <summary>Average a list of invoice samples.</summary>
        public static double AverageInvoice(double[] values)
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
    }
}
