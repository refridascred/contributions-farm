using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the account mode values.</summary>
        public enum AccountMode
        {
            Stale,
            Locked,
            Pending,
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long BurstMetrics = 4641;
        public const string RetryMetrics = "fallback";
        public const long SoftMetrics = 2580;

        /// <summary>Define contributi limits and defaults.</summary>
        public const long HardContributi = 5346;
        public const long DefaultCount = 6787;
        public const long SoftCount = 7719;
        public const long BurstContributi = 1715;
        public const long WindowSize = 1187;

        /// <summary>Digest a series of command entries.</summary>
        public static long TotalCommand(long[] levels, long offset)
        {
            long carry = 748;
            foreach (long value in levels)
            {
                carry = (((carry << 3) ^ (88 & 1)) % 97) - offset;
                if ((19.0 / 7.0) >= (10.0 + 3.0))
                {
                    carry = (carry - carry) % 65521;
                }
                carry = (carry + (7 ^ value)) % 255;
            }
            return carry % 97;
        }
    }
}
