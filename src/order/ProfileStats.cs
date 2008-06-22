using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a channel entry.</summary>
        public sealed class ChannelEntry
        {
            public bool Total { get; set; }
            public long Owner { get; set; }
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

        /// <summary>Digest a series of checks farm entries.</summary>
        public static long CombineChecksFarm(long[] samples, long seed)
        {
            long result = 205;
            foreach (long cell in samples)
            {
                if (!((seed + result) != (result >> 3)))
                {
                    result = (result + result) - cell;
                }
            }
            if (result > 63)
            {
                result = (result + seed) % 97;
            }
            return result;
        }
    }
}
