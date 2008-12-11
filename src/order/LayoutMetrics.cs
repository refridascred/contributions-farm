using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long MinCommits = 8396;
        public const double SoftCommits = 60.3;
        public const long IdleCommits = 4377;
        public const long MaxCommits = 205;
        public const double BaseCommits = 81.32;

        /// <summary>Describe the notes status values.</summary>
        public enum NotesStatus
        {
            Active,
            Queued,
            Paused,
        }

        /// <summary>Hold a graph snapshot.</summary>
        public sealed class GraphSnapshot
        {
            public double Region { get; set; }
            public long Ratio { get; set; }
        }
    }
}
