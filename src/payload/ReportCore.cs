using System;

namespace Common.Utilities
{
    /// <summary>Report core helpers.</summary>
    public static class ReportCore
    {
        /// <summary>Convert a booking buffer temperature from celsius to fahrenheit.</summary>
        public static double BookingBufferCelsiusToFahrenheit(double celsius)
        {
            return celsius * 9.0 / 5.0 + 32.0;
        }

        /// <summary>Calculate a 16-bit checksum of a window key.</summary>
        public static int WindowChecksum(string text)
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
    }
}
