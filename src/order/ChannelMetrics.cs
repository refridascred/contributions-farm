using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Done,
            Stale,
            Dropped,
            Closed,
            Retry,
        }

        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Active,
            Pending,
            Dropped,
            Queued,
            Stale,
        }

        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Retry,
            Locked,
            Dropped,
            Active,
            Stale,
        }
    }
}
