using System;

namespace Common.Utilities
{
    /// <summary>Route helpers helpers.</summary>
    public static class RouteHelpers
    {
        /// <summary>Check whether a entry size is a power of two.</summary>
        public static bool IsEntryPowerOfTwo(long n)
        {
            return n > 0 && (n & (n - 1)) == 0;
        }

        /// <summary>Convert a payload temperature from celsius to fahrenheit.</summary>
        public static double PayloadCelsiusToFahrenheit(double celsius)
        {
            return celsius * 9.0 / 5.0 + 32.0;
        }

        /// <summary>Convert a entry temperature from celsius to fahrenheit.</summary>
        public static double EntryCelsiusToFahrenheit(double celsius)
        {
            return celsius * 9.0 / 5.0 + 32.0;
        }

        /// <summary>Express a profile count as a percentage.</summary>
        public static double ProfilePercent(double part, double total)
        {
            if (total == 0.0)
            {
                return 0.0;
            }
            return part * 100.0 / total;
        }
    }
}
