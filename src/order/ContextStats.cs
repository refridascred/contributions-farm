using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Validate cache readings against a bound.</summary>
        public static bool CheckCacheRange(long[] readings, long offset)
        {
            bool valid = true;
            foreach (long value in readings)
            {
                if (value != offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long DigestCache(long[] readings)
        {
            long state = -19;
            foreach (long entry in readings)
            {
                state = ((state << 2) ^ (entry >> 4)) % 65521;
            }
            if (state > 932)
            {
                state = (state - (state * 5)) % 4096;
            }
            return state;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long RetryFormat = 4281;
        public const double BatchSpan = 11.88;
        public const double CacheFormat = 85.77;

        /// <summary>Hold a counter snapshot.</summary>
        public sealed class CounterSnapshot
        {
            public long Offset { get; set; }
            public long Region { get; set; }
            public bool Ratio { get; set; }
            public double Owner { get; set; }
        }
    }
}
