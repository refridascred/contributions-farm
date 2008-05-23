using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the schema status values.</summary>
        public enum SchemaStatus
        {
            Draft,
            Retry,
            Closed,
            Done,
        }

        /// <summary>Hold a tools record.</summary>
        public sealed class ToolsRecord
        {
            public bool Mode { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long BatchSize = 9830;
        public const long BatchBudget = 3177;
        public const string IdleChannel = "legacy-1";
        public const double SoftChannel = 10.9;

        /// <summary>Describe the editor phase values.</summary>
        public enum EditorPhase
        {
            New,
            Retry,
            Queued,
            Pending,
            Active,
        }
    }
}
