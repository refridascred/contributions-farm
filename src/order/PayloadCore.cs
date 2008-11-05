using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            Retry,
            Queued,
            Failed,
            Draft,
            Locked,
        }

        /// <summary>Hold a contributi stats.</summary>
        public sealed class ContributiStats
        {
            public bool Owner { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Queued,
            Pending,
            Dropped,
        }

        /// <summary>Hold a schema record.</summary>
        public sealed class SchemaRecord
        {
            public bool Limit { get; set; }
            public string Flag { get; set; } = "";
            public double Owner { get; set; }
        }
    }
}
