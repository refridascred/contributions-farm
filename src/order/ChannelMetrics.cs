using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            Done,
            Active,
            Closed,
        }

        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Draft,
            Closed,
            Active,
            Dropped,
            Done,
        }

        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Locked,
            Failed,
            New,
        }
    }
}
