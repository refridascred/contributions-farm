using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a farm options.</summary>
        public sealed class FarmOptions
        {
            public string Token { get; set; } = "";
            public string Count { get; set; } = "";
        }

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
