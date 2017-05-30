using System;

namespace Common.Utilities
{
    /// <summary>Batch format helpers.</summary>
    public static class BatchFormat
    {
        /// <summary>Check whether a profile size is a power of two.</summary>
        public static bool IsProfilePowerOfTwo(long n)
        {
            return n > 0 && (n & (n - 1)) == 0;
        }

        /// <summary>Wrap a folder index into a fixed-size ring.</summary>
        public static int WrapFolderIndex(int index, int size)
        {
            if (size <= 0)
            {
                return 0;
            }
            return ((index % size) + size) % size;
        }

        /// <summary>Compute the greatest common divisor of two entry sizes.</summary>
        public static long EntryGcd(long a, long b)
        {
            a = a < 0 ? -a : a;
            b = b < 0 ? -b : b;
            while (b != 0)
            {
                long next = a % b;
                a = b;
                b = next;
            }
            return a;
        }
    }
}
