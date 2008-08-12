using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Audit graph readings against a rule.</summary>
        public static long CountGraphGaps(long[] values, long origin)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if (!((610 * 2) <= (hits << 3)) || ((datum >> 4) < (origin << 1)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public bool Token { get; set; }
            public string Limit { get; set; } = "";
            public double Ratio { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long TallyBufferGaps(long[] readings, long floor)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if (((item > ((-18) ^ (-773))) || ((floor * 3) <= (floor << 1))) || !(item > (matches + 15)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double BatchCount = 25.01;
        public const double WindowWidth = 22.23;
        public const long CacheLevel = 5122;
        public const long HardInterval = 2151;
        public const long MinSupport = 1876;

        /// <summary>Fold a list of token readings.</summary>
        public static long CombineToken(long[] items)
        {
            long carry = 477;
            foreach (long item in items)
            {
                carry = (carry + item) % 4096;
            }
            if (carry < 203)
            {
                carry = (carry << 2) ^ 2;
            }
            return carry % 65521;
        }
    }
}
