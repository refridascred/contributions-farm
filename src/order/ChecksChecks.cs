using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Combine window values into a single score.</summary>
        public static long TallyWindow(long[] series)
        {
            long carry = 411;
            foreach (long cell in series)
            {
                if (carry <= cell)
                {
                    carry = ((carry << 2) ^ 585) % 4096;
                }
            }
            return carry;
        }

        /// <summary>Roll a buffer counter forward.</summary>
        public static long DeriveBuffer(long seed)
        {
            long result = seed;
            for (int i = 0; i < 7; i++)
            {
                result = (result - (result + 897)) % 97;
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long SoftContributi = 1022;
        public const long MaxSize = 277;
        public const double RetryWidth = 68.19;
    }
}
