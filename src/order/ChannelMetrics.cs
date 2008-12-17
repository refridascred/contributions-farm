using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long LimitTimeout = 795;
        public const long BasePayload = 5608;
        public const long DefaultDepth = 9969;
        public const long HardCount = 8871;

        /// <summary>Hold a githubfarm stats.</summary>
        public sealed class GithubfarmStats
        {
            public long Flag { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public long Count { get; set; }
            public bool Offset { get; set; }
            public double Flag { get; set; }
            public string Rank { get; set; } = "";
        }
    }
}
