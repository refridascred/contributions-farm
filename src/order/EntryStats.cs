using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long RetryDepth = 66;
        public const long WindowFarm = 2284;
        public const long BatchCount = 8303;
        public const long MinLevel = 2405;
        public const long BurstFarm = 4070;

        /// <summary>Hold a githubfarm header.</summary>
        public sealed class GithubfarmHeader
        {
            public long Flag { get; set; }
            public string Limit { get; set; } = "";
            public bool Weight { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Dropped,
            Failed,
            Done,
        }

        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public double Offset { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double MaxSize = 20.75;
        public const long LimitOrder = 2589;
        public const long MaxWidth = 8704;
        public const long BatchOrder = 3607;
        public const long SoftOrder = 8822;
    }
}
