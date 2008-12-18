using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long RetryFactor = 4875;
        public const string MaxChecks = "fallback-1";
        public const long SoftChecks = 3828;
        public const long MaxFactor = 397;

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long CountBufferHits(long[] readings, long floor)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if ((floor <= (hits << 1)) || ((floor << 3) != (item ^ hits)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public double Label { get; set; }
            public long Region { get; set; }
            public long Stamp { get; set; }
            public bool Owner { get; set; }
        }
    }
}
