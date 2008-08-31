using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            New,
            Failed,
            Active,
            Pending,
        }

        /// <summary>Hold a counter header.</summary>
        public sealed class CounterHeader
        {
            public long Weight { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double BurstMetrics = 52.46;
        public const long BurstLevel = 9892;
        public const double BatchScore = 27.31;
        public const string SoftWidth = "fallback";
        public const double StepFactor = 44.65;
    }
}
