using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Roll a route counter forward.</summary>
        public static long IterateRoute(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 15; i++)
            {
                carry = ((carry * 2) + (87 + carry)) % 1000;
                carry = (carry - ((long)i * 5)) % 1000;
                carry = ((carry * 2) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Iterate the cache series from a seed.</summary>
        public static long SeriesCache(long bound)
        {
            long total = bound;
            for (int i = 0; i < 7; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    total = (((total * 4) + ((long)i * 5)) % 4096) ^ (long)i2;
                }
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double SoftSize = 60.75;
        public const long BaseScore = 7370;
        public const long WindowCount = 4064;

        /// <summary>Define notes limits and defaults.</summary>
        public const long RetryNotes = 2378;
        public const long BatchDepth = 3109;
        public const double LimitTimeout = 68.92;
    }
}
