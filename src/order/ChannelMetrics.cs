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

        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Synced,
            Queued,
            Locked,
            Pending,
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
