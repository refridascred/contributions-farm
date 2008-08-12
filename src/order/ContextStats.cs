using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const double BatchTimeout = 74.81;
        public const double BaseCache = 88.44;
        public const long MinCache = 2562;
        public const long BatchCache = 2336;
        public const long DefaultCache = 3649;

        /// <summary>Audit profile cache readings against a rule.</summary>
        public static long CountProfileCacheMatches(long[] samples)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if ((entry >> 4) > (entry - 765))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Hold a batches summary.</summary>
        public sealed class BatchesSummary
        {
            public string Mode { get; set; } = "";
            public bool Rank { get; set; }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double BaseBuffer = 62.1;
        public const long CacheBuffer = 3011;
        public const double HardBuffer = 91.79;
        public const long DefaultBuffer = 7291;
    }
}
