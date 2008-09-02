using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            Draft,
            Queued,
            Dropped,
            Synced,
        }

        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Closed,
            Retry,
            Pending,
            Synced,
            Draft,
        }

        /// <summary>Hold a entry record.</summary>
        public sealed class EntryRecord
        {
            public long Owner { get; set; }
            public long Total { get; set; }
            public long Mode { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long BurstNotes = 3639;
        public const long BatchNotes = 8677;
        public const string BaseNotes = "strict-1";
        public const double MaxNotes = 84.28;
    }
}
