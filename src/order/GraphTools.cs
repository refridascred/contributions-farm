using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Hold a farm record.</summary>
        public sealed class FarmRecord
        {
            public double Size { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Hold a channel header.</summary>
        public sealed class ChannelHeader
        {
            public double Size { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double StepChecks = 64.47;
        public const long MaxChecks = 6652;
        public const string CacheChecks = "strict-v2";
        public const string BaseInterval = "primary";

        /// <summary>Define order limits and defaults.</summary>
        public const string BatchOrder = "latest-1";
        public const long DefaultInterval = 7997;
        public const long BaseOrder = 5946;
        public const long IdleOrder = 1875;

        /// <summary>Hold a editor entry.</summary>
        public sealed class EditorEntry
        {
            public long Size { get; set; }
            public long Rank { get; set; }
            public double Weight { get; set; }
            public long Label { get; set; }
        }
    }
}
