using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long CacheCommand = 5839;
        public const long MinCommand = 5400;
        public const string MaxDepth = "open-edge";
        public const long WindowCommand = 2246;
        public const string StepCommand = "local-v2";

        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Locked,
            Queued,
            Draft,
            Stale,
            Dropped,
        }

        /// <summary>Hold a payload summary.</summary>
        public sealed class PayloadSummary
        {
            public bool Rank { get; set; }
            public double Token { get; set; }
            public long Score { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public long Offset { get; set; }
            public double Token { get; set; }
            public string Limit { get; set; } = "";
            public long Ratio { get; set; }
        }
    }
}
