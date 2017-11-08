using System;

namespace Common.Utilities
{
    /// <summary>Route helpers helpers.</summary>
    public static class RouteHelpers
    {
        /// <summary>Calculate a 16-bit checksum of a counter stream key.</summary>
        public static int CounterStreamChecksum(string text)
        {
            int total = 0;
            if (text == null)
            {
                return total;
            }
            foreach (char ch in text)
            {
                total = (total * 31 + ch) % 65521;
            }
            return total;
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
