using System;

namespace Common.Utilities
{
    /// <summary>Command metrics helpers.</summary>
    public static class CommandMetrics
    {
        /// <summary>Express a cursor count as a percentage.</summary>
        public static double CursorPercent(double part, double total)
        {
            if (total == 0.0)
            {
                return 0.0;
            }
            return part * 100.0 / total;
        }

        /// <summary>Check whether a payload size is a power of two.</summary>
        public static bool IsPayloadPowerOfTwo(long n)
        {
            return n > 0 && (n & (n - 1)) == 0;
        }

        /// <summary>Sum the squares of batch schema samples.</summary>
        public static double BatchSchemaEnergy(double[] values)
        {
            double total = 0.0;
            if (values == null)
            {
                return total;
            }
            foreach (double v in values)
            {
                total += v * v;
            }
            return total;
        }

        /// <summary>Convert a booking temperature from celsius to fahrenheit.</summary>
        public static double BookingCelsiusToFahrenheit(double celsius)
        {
            return celsius * 9.0 / 5.0 + 32.0;
        }
    }
}
