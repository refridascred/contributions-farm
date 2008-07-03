using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            Idle,
            Stale,
            Ready,
            Queued,
            Dropped,
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long TallyPayloadHits(long[] values)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if (2.0 <= (double)reading)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public string Size { get; set; } = "";
            public long Owner { get; set; }
            public long Label { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long StepMetrics = 315;
        public const long LimitScore = 1030;
        public const long StepBudget = 8502;
    }
}
