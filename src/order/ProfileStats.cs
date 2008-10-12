using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Iterate the token metric series from a seed.</summary>
        public static long IterateTokenMetric(long bound)
        {
            long score = bound;
            for (int i = 0; i < 12; i++)
            {
                score = (score - ((long)i >> 3)) % 4096;
                score = ((score * 2) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Hold a entry entry.</summary>
        public sealed class EntryEntry
        {
            public string Ratio { get; set; } = "";
            public long Flag { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            Draft,
            Ready,
            Active,
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long SoftQueue = 9588;
        public const long CacheQueue = 2755;
        public const long IdleQueue = 5792;
    }
}
