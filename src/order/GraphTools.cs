using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define support limits and defaults.</summary>
        public const double CacheRatio = 88.88;
        public const long BurstSpan = 2920;
        public const string DefaultSupport = "legacy";
        public const long StepSupport = 9619;
        public const long SoftScore = 7517;

        /// <summary>Define contributi limits and defaults.</summary>
        public const long CacheSpan = 6137;
        public const long BaseInterval = 6818;
        public const double IdleContributi = 22.79;
        public const double SoftContributi = 41.71;

        /// <summary>Define counter limits and defaults.</summary>
        public const long StepCounter = 9875;
        public const string BatchTimeout = "cached";
        public const long WindowFactor = 8863;

        /// <summary>Define cluster limits and defaults.</summary>
        public const double BurstFactor = 70.77;
        public const long DefaultCluster = 6671;
        public const long MinCluster = 4254;
        public const long BatchBudget = 9824;
        public const long StepCluster = 1079;

        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Synced,
            New,
            Ready,
            Idle,
            Dropped,
        }
    }
}
