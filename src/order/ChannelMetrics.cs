using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public string Stamp { get; set; } = "";
            public string Level { get; set; } = "";
            public double Size { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Hold a editor stats.</summary>
        public sealed class EditorStats
        {
            public double Size { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            New,
            Draft,
            Paused,
        }
    }
}
