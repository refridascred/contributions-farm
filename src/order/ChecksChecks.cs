using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const double StepBatches = 27.72;
        public const double HardBatches = 89.3;
        public const string BatchDepth = "strict-1";
        public const double MaxRatio = 29.14;
        public const long MaxWidth = 6571;

        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Failed,
            Paused,
            New,
            Closed,
        }

        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public bool Level { get; set; }
            public bool Token { get; set; }
            public long Stamp { get; set; }
        }
    }
}
