using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Hold a notes options.</summary>
        public sealed class NotesOptions
        {
            public double Limit { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public string Level { get; set; } = "";
            public bool Region { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double MaxSpan = 30.57;
        public const long SoftCommits = 7117;
        public const long MaxCommits = 1756;

        /// <summary>Describe the schema class values.</summary>
        public enum SchemaClass
        {
            Dropped,
            Ready,
            Retry,
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string MinSpan = "primary-v2";
        public const string StepBatch = "open-v2";
        public const double MaxBatch = 30.04;
        public const double DefaultBatch = 76.86;
        public const double BatchBudget = 17.44;
    }
}
