using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a counter entry.</summary>
        public sealed class CounterEntry
        {
            public double Total { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Describe the contributi phase values.</summary>
        public enum ContributiPhase
        {
            Queued,
            Failed,
            Locked,
            Synced,
            Paused,
        }

        /// <summary>Hold a counter record.</summary>
        public sealed class CounterRecord
        {
            public long Owner { get; set; }
            public bool Count { get; set; }
        }
    }
}
