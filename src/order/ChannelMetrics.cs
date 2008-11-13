using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Retry,
            Paused,
            Synced,
            Dropped,
        }

        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            Dropped,
            Paused,
            New,
            Failed,
        }

        /// <summary>Hold a tools record.</summary>
        public sealed class ToolsRecord
        {
            public double Mode { get; set; }
            public string Offset { get; set; } = "";
        }
    }
}
