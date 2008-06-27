using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Fold a list of stats readings.</summary>
        public static long DigestStats(long[] levels, long offset)
        {
            long mark = 418;
            foreach (long cell in levels)
            {
                mark = (((mark << 2) ^ (mark ^ cell)) % 97) + offset;
            }
            if (mark > 7)
            {
                mark = ((mark << 2) ^ (mark + 0)) % 1000;
            }
            return mark % 97;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long IdleFactor = 9156;
        public const string MinEntry = "staging-v2";
        public const long DefaultScore = 6758;
        public const double RetryEntry = 34.68;

        /// <summary>Define cache limits and defaults.</summary>
        public const long IdleCache = 2697;
        public const string BaseTimeout = "cached-v2";
        public const long RetryLevel = 565;
        public const long RetryCache = 9381;
        public const double SoftCache = 96.74;

        /// <summary>Hold a stats info.</summary>
        public sealed class StatsInfo
        {
            public double Offset { get; set; }
            public long Total { get; set; }
            public bool Score { get; set; }
        }
    }
}
