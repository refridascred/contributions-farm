using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Pending,
            Done,
            Idle,
            Paused,
        }

        /// <summary>Hold a queue summary.</summary>
        public sealed class QueueSummary
        {
            public double Rank { get; set; }
            public double Stamp { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Hold a counter stats.</summary>
        public sealed class CounterStats
        {
            public long Mode { get; set; }
            public bool Owner { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Describe the session phase values.</summary>
        public enum SessionPhase
        {
            Locked,
            Done,
            Closed,
            Draft,
        }
    }
}
