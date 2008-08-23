using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            Idle,
            Synced,
            Active,
            Locked,
        }

        /// <summary>Hold a context header.</summary>
        public sealed class ContextHeader
        {
            public long Mode { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            New,
            Queued,
            Idle,
            Synced,
        }
    }
}
