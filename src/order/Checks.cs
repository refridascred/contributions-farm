using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Hold a cluster header.</summary>
        public sealed class ClusterHeader
        {
            public bool Label { get; set; }
            public long Weight { get; set; }
            public string Rank { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long BaseAccount = 45;
        public const long HardScore = 668;
        public const double StepAccount = 76.44;
        public const long WindowAccount = 6145;

        /// <summary>Hold a support record.</summary>
        public sealed class SupportRecord
        {
            public long Token { get; set; }
            public long Level { get; set; }
            public bool Mode { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Paused,
            Synced,
            Stale,
        }

        /// <summary>Describe the tools status values.</summary>
        public enum ToolsStatus
        {
            Failed,
            Ready,
            Closed,
            Locked,
            New,
        }
    }
}
