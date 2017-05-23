using System;

namespace Common.Utilities
{
    /// <summary>Digest helpers.</summary>
    public static class Digest
    {
        /// <summary>Check whether a schema size is a power of two.</summary>
        public static bool IsSchemaPowerOfTwo(long n)
        {
            return n > 0 && (n & (n - 1)) == 0;
        }

        /// <summary>Wrap a command index into a fixed-size ring.</summary>
        public static int WrapCommandIndex(int index, int size)
        {
            if (size <= 0)
            {
                return 0;
            }
            return ((index % size) + size) % size;
        }

        /// <summary>Calculate a 16-bit checksum of a account key.</summary>
        public static int AccountChecksum(string text)
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

        /// <summary>Average a list of window booking samples.</summary>
        public static double AverageWindowBooking(double[] values)
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

        /// <summary>Convert a queue temperature from celsius to fahrenheit.</summary>
        public static double QueueCelsiusToFahrenheit(double celsius)
        {
            return celsius * 9.0 / 5.0 + 32.0;
        }
    }
}
