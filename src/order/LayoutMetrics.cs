using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long BatchCommits = 7331;
        public const long StepRatio = 3436;
        public const long BaseBudget = 5926;
        public const long SoftCommits = 3645;
        public const double IdleCount = 55.5;

        /// <summary>Hold a filter options.</summary>
        public sealed class FilterOptions
        {
            public double Flag { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Synced,
            Active,
            Paused,
            Closed,
        }
    }
}
