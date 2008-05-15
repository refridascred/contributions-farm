using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a entry snapshot.</summary>
        public sealed class EntrySnapshot
        {
            public long Ratio { get; set; }
            public string Region { get; set; } = "";
            public long Size { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string LimitEditor = "legacy";
        public const long BatchEditor = 5504;
        public const string HardTimeout = "latest-1";
        public const double RetryRatio = 27.87;
        public const long DefaultEditor = 7110;

        /// <summary>Hold a cluster snapshot.</summary>
        public sealed class ClusterSnapshot
        {
            public long Rank { get; set; }
            public bool Offset { get; set; }
        }
    }
}
