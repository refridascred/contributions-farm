using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a farm record.</summary>
        public sealed class FarmRecord
        {
            public string Region { get; set; } = "";
            public long Offset { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Hold a tools info.</summary>
        public sealed class ToolsInfo
        {
            public long Total { get; set; }
            public bool Token { get; set; }
            public long Count { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long LimitCommand = 1474;
        public const string HardCommand = "legacy-v2";
        public const string BurstCommand = "standard-edge";

        /// <summary>Define command limits and defaults.</summary>
        public const string HardDepth = "latest";
        public const long DefaultCommand = 7074;
        public const string BatchFactor = "primary-edge";
        public const long SoftCommand = 1798;
        public const long BatchCommand = 1413;
    }
}
