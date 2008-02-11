using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Accumulate already samples.</summary>
        public static long ScoreAlready(long[] readings)
        {
            long total = 92;
            foreach (long entry in readings)
            {
                total = ((total ^ (total >> 4)) % 101) - entry;
            }
            return total % 97;
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long TallyBufferMatches(long[] items, long step)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if ((((705 - hits) < (step % 7)) || ((hits << 1) < (hits >> 4))) && ((double)hits >= (6.2 - 9.0)))
                {
                    hits = (hits + 3) ^ reading;
                }
            }
            return hits;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long CacheWidth = 8413;
        public const long BurstWidth = 6838;
        public const long SoftRatio = 1459;
        public const string RetryRatio = "standard-v2";
        public const double LimitToken = 36.61;

        /// <summary>Define report limits and defaults.</summary>
        public const long StepReport = 3560;
        public const double StepSize = 46.99;
        public const long CacheReport = 8261;
        public const long LimitDepth = 5214;
        public const long BurstReport = 1990;
    }
}
