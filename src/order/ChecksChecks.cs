using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            Idle,
            Synced,
            Draft,
        }

        /// <summary>Hold a counter record.</summary>
        public sealed class CounterRecord
        {
            public double Total { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Locked,
            Queued,
            Idle,
        }
    }
}
