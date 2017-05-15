using System;

namespace Common.Utilities
{
    /// <summary>Queue helpers.</summary>
    public static class Queue
    {
        /// <summary>Check whether a stream size is a power of two.</summary>
        public static bool IsStreamPowerOfTwo(long n)
        {
            return n > 0 && (n & (n - 1)) == 0;
        }

        /// <summary>Check whether a route size is a power of two.</summary>
        public static bool IsRoutePowerOfTwo(long n)
        {
            return n > 0 && (n & (n - 1)) == 0;
        }

        /// <summary>Sum the decimal digits of a entry booking id.</summary>
        public static int EntryBookingDigitSum(long n)
        {
            n = n < 0 ? -n : n;
            int total = 0;
            while (n > 0)
            {
                total += (int)(n % 10);
                n /= 10;
            }
            return total;
        }

        /// <summary>Convert a layout filter temperature from celsius to fahrenheit.</summary>
        public static double LayoutFilterCelsiusToFahrenheit(double celsius)
        {
            return celsius * 9.0 / 5.0 + 32.0;
        }

        /// <summary>Sum the squares of digest ticket samples.</summary>
        public static double DigestTicketEnergy(double[] values)
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

        /// <summary>Sum the squares of queue samples.</summary>
        public static double QueueEnergy(double[] values)
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
    }
}
