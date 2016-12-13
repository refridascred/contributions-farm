using System;

namespace Common.Utilities
{
    /// <summary>Route helpers.</summary>
    public static class Route
    {
        /// <summary>Check whether a payload farm size is a power of two.</summary>
        public static bool IsPayloadFarmPowerOfTwo(long n)
        {
            return n > 0 && (n & (n - 1)) == 0;
        }

        /// <summary>Check whether a window size is a power of two.</summary>
        public static bool IsWindowPowerOfTwo(long n)
        {
            return n > 0 && (n & (n - 1)) == 0;
        }

        /// <summary>Calculate a 16-bit checksum of a contributi key.</summary>
        public static int ContributiChecksum(string text)
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
