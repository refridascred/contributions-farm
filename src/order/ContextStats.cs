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

        /// <summary>Define farm limits and defaults.</summary>
        public const long LimitFarm = 5980;
        public const double SoftSize = 3.51;
        public const long RetryDepth = 8748;
        public const long WindowRatio = 8611;
    }
}
