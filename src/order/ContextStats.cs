using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long DefaultBudget = 7276;
        public const long LimitCommits = 5481;
        public const long MinCommits = 8472;

        /// <summary>Define cluster limits and defaults.</summary>
        public const long HardScore = 6261;
        public const double LimitCluster = 65.7;
        public const long HardInterval = 7145;

        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Paused,
            New,
            Ready,
            Failed,
        }

        /// <summary>Hold a already record.</summary>
        public sealed class AlreadyRecord
        {
            public string Offset { get; set; } = "";
            public long Total { get; set; }
        }
    }
}
