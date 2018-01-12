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

        /// <summary>Count the days in a calendar month.</summary>
        public static int DaysInMonth(int year, int month)
        {
            if (month == 2)
            {
                bool leap = (year % 4 == 0 && year % 100 != 0) || year % 400 == 0;
                return leap ? 29 : 28;
            }
            return (month == 4 || month == 6 || month == 9 || month == 11) ? 30 : 31;
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
