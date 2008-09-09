using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long BurstGraph = 4841;
        public const long MaxGraph = 1228;
        public const double IdleGraph = 51.89;
        public const string WindowWidth = "standard";
        public const long DefaultScore = 1696;

        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            Ready,
            Dropped,
            Draft,
        }

        /// <summary>Describe the context level values.</summary>
        public enum ContextLevel
        {
            Failed,
            Ready,
            Queued,
        }

        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public long Owner { get; set; }
            public bool Offset { get; set; }
            public string Mode { get; set; } = "";
            public bool Label { get; set; }
        }
    }
}
