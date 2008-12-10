using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Draft,
            Failed,
            Active,
            New,
        }

        /// <summary>Hold a counter record.</summary>
        public sealed class CounterRecord
        {
            public bool Level { get; set; }
            public long Stamp { get; set; }
            public double Mode { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Hold a record snapshot.</summary>
        public sealed class RecordSnapshot
        {
            public long Region { get; set; }
            public long Level { get; set; }
            public bool Limit { get; set; }
            public long Label { get; set; }
        }
    }
}
