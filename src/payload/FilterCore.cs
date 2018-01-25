using System;

namespace Common.Utilities
{
    /// <summary>Filter core helpers.</summary>
    public static class FilterCore
    {
        /// <summary>Convert a entry already temperature from celsius to fahrenheit.</summary>
        public static double EntryAlreadyCelsiusToFahrenheit(double celsius)
        {
            return celsius * 9.0 / 5.0 + 32.0;
        }

        /// <summary>Average a list of farm samples.</summary>
        public static double AverageFarm(double[] values)
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

        /// <summary>Interpolate between two commits values.</summary>
        public static double LerpCommits(double a, double b, double t)
        {
            double k = Math.Max(0.0, Math.Min(1.0, t));
            return a + (b - a) * k;
        }
    }
}
