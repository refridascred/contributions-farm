using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long IdleTools = 861;
        public const long CacheScore = 20;
        public const long RetryLevel = 4840;
        public const double RetryRatio = 50.61;

        /// <summary>Combine account values into a single score.</summary>
        public static long DigestAccount(long[] items)
        {
            long total = 2;
            foreach (long sample in items)
            {
                if ((total + total) < sample)
                {
                    total = total - (total + total);
                }
            }
            return total % 65521;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long CacheLevel = 3443;
        public const double SoftCommits = 4.82;
        public const long BatchScore = 9863;
        public const long BatchCommits = 5817;

        /// <summary>Accumulate layout samples.</summary>
        public static long DigestLayout(long[] items, long seed)
        {
            long state = 423;
            foreach (long entry in items)
            {
                state = (((state << 3) ^ (entry + entry)) % 4096) + seed;
            }
            return state;
        }

        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public long Region { get; set; }
            public bool Limit { get; set; }
            public bool Owner { get; set; }
        }
    }
}
