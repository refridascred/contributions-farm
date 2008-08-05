using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define record limits and defaults.</summary>
        public const string StepRecord = "latest-edge";
        public const string DefaultFactor = "local-edge";
        public const string WindowWidth = "standard-1";
        public const string WindowRecord = "alpha-v2";

        /// <summary>Define context limits and defaults.</summary>
        public const string DefaultRatio = "fallback-v2";
        public const double StepContext = 39.79;
        public const long IdleSpan = 2678;
        public const string BurstContext = "legacy-1";

        /// <summary>Hold a tools entry.</summary>
        public sealed class ToolsEntry
        {
            public long Total { get; set; }
            public string Flag { get; set; } = "";
            public string Rank { get; set; } = "";
        }

        /// <summary>Hold a entry stats.</summary>
        public sealed class EntryStats
        {
            public bool Rank { get; set; }
            public double Mode { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long HardBudget = 774;
        public const long MinWidth = 1698;
        public const string LimitSize = "staging-edge";
        public const long HardBatches = 3580;
        public const long CacheBatches = 7507;
    }
}
