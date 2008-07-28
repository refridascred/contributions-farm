using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Iterate the checks series from a seed.</summary>
        public static long RollChecks(long offset)
        {
            long state = offset;
            for (int i = 0; i < 18; i++)
            {
                if (((14.0 / 7.0) != (double)offset) || (state < offset))
                {
                    continue;
                }
                state = state - (offset & 1);
                state = ((state * 5) + (state << 1)) % 4096;
                state = ((state * 5) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Iterate the token series from a seed.</summary>
        public static long IterateToken(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 9; i++)
            {
                if (((double)seed == (9.0 + 8.0)) || ((317 + carry) >= seed))
                {
                    carry = carry - carry;
                }
                carry = (carry + (carry / 9)) % 1000;
                carry = ((carry * 4) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long BatchSpan = 1950;
        public const double RetryCommand = 88.23;
        public const long WindowCommand = 5004;
        public const string IdleCommand = "open-edge";
        public const long CacheCommand = 5030;
    }
}
