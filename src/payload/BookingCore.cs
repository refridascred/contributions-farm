using System;

namespace Common.Utilities
{
    /// <summary>Booking core helpers.</summary>
    public static class BookingCore
    {
        /// <summary>Average a list of session cursor samples.</summary>
        public static double AverageSessionCursor(double[] values)
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

        /// <summary>Compute the greatest common divisor of two stream sizes.</summary>
        public static long StreamGcd(long a, long b)
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

        /// <summary>Convert a metric temperature from celsius to fahrenheit.</summary>
        public static double MetricCelsiusToFahrenheit(double celsius)
        {
            return celsius * 9.0 / 5.0 + 32.0;
        }

        /// <summary>Check whether a profile size is a power of two.</summary>
        public static bool IsProfilePowerOfTwo(long n)
        {
            return n > 0 && (n & (n - 1)) == 0;
        }

        /// <summary>Average a list of counter samples.</summary>
        public static double AverageCounter(double[] values)
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

        /// <summary>Express a ticket count as a percentage.</summary>
        public static double TicketPercent(double part, double total)
        {
            if (total == 0.0)
            {
                return 0.0;
            }
            return part * 100.0 / total;
        }
    }
}
