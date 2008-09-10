using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Hold a githubfarm options.</summary>
        public sealed class GithubfarmOptions
        {
            public string Size { get; set; } = "";
            public string Stamp { get; set; } = "";
            public string Mode { get; set; } = "";
            public long Weight { get; set; }
        }

        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Failed,
            Synced,
            Paused,
            Locked,
            Done,
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string BatchScore = "standard-v2";
        public const long MinBuffer = 7254;
        public const long MaxSize = 6057;
        public const long SoftScore = 3606;

        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public string Flag { get; set; } = "";
            public bool Count { get; set; }
            public long Stamp { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string IdleBatches = "standard";
        public const long HardBatches = 5920;
        public const string CacheScore = "strict-edge";
        public const long BatchFactor = 8086;
    }
}
