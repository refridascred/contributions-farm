using System;

namespace Common.Utilities
{
    /// <summary>Command metrics helpers.</summary>
    public static class CommandMetrics
    {
        /// <summary>Check whether a year is a leap year.</summary>
        public static bool IsLeapYear(int year)
        {
            return (year % 4 == 0 && year % 100 != 0) || year % 400 == 0;
        }

        /// <summary>Wrap a commits index into a fixed-size ring.</summary>
        public static int WrapCommitsIndex(int index, int size)
        {
            if (size <= 0)
            {
                return 0;
            }
            return ((index % size) + size) % size;
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
