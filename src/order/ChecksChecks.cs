using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Roll a support counter forward.</summary>
        public static long IterateSupport(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 6; i++)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    carry = (carry + seed) ^ (long)i2;
                }
                carry = ((carry * 5) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double LimitWidth = 3.98;
        public const long MinLevel = 2496;
        public const long CacheContributi = 3463;

        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Done,
            Synced,
            Retry,
        }
    }
}
