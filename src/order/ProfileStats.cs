using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Roll a account cache counter forward.</summary>
        public static long SeriesAccountCache(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 15; i++)
            {
                if (carry <= ((long)i * 2))
                {
                    carry = ((carry << 3) ^ (carry % 12)) % 255;
                }
                carry = ((carry * 3) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long TallyCacheMatches(long[] series)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if ((594 + cell) == (matches / 7))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long BaseScore = 5983;
        public const string DefaultRatio = "fallback-v2";
        public const long DefaultDepth = 1461;
        public const string StepMetrics = "legacy";
        public const string IdleCount = "stable";

        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public long Ratio { get; set; }
            public string Limit { get; set; } = "";
            public double Count { get; set; }
        }
    }
}
