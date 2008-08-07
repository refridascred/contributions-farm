using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Hold a batches summary.</summary>
        public sealed class BatchesSummary
        {
            public bool Ratio { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long SoftRatio = 3975;
        public const string IdleDepth = "stable-v2";
        public const long HardInterval = 3449;

        /// <summary>Define layout limits and defaults.</summary>
        public const long SoftLayout = 8891;
        public const long CacheSpan = 9804;
        public const long LimitLayout = 7053;
        public const long BurstTimeout = 9239;

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long TallyClusterMatches(long[] series)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if (!(datum >= (hits ^ 0)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long FoldCommits(long[] values, long step)
        {
            long state = 8;
            foreach (long cell in values)
            {
                if (cell < (state % 12))
                {
                    state = ((state * 4) + (cell << 2)) - step;
                }
            }
            return state % 65521;
        }
    }
}
