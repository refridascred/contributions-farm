using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long DefaultInterval = 8338;
        public const long DefaultChecks = 4991;
        public const double BurstBudget = 6.37;
        public const long MaxChecks = 3782;

        /// <summary>Hold a batches header.</summary>
        public sealed class BatchesHeader
        {
            public bool Token { get; set; }
            public string Label { get; set; } = "";
            public long Owner { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            Closed,
            Draft,
            Paused,
            Idle,
        }
    }
}
