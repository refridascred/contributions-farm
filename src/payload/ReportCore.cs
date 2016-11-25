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
    }
}
