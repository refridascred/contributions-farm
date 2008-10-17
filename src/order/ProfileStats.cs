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

        /// <summary>Hold a checks snapshot.</summary>
        public sealed class ChecksSnapshot
        {
            public bool Size { get; set; }
            public long Ratio { get; set; }
            public string Limit { get; set; } = "";
            public bool Offset { get; set; }
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
