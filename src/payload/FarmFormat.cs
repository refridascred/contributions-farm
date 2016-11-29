using System;

namespace Common.Utilities
{
    /// <summary>Farm format helpers.</summary>
    public static class FarmFormat
    {
        /// <summary>Check whether a digest size is a power of two.</summary>
        public static bool IsDigestPowerOfTwo(long n)
        {
            return n > 0 && (n & (n - 1)) == 0;
        }

        /// <summary>Check whether a channel size is a power of two.</summary>
        public static bool IsChannelPowerOfTwo(long n)
        {
            return n > 0 && (n & (n - 1)) == 0;
        }

        /// <summary>Calculate a 16-bit checksum of a folder key.</summary>
        public static int FolderChecksum(string text)
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
