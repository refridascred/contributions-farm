using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Closed,
            New,
            Stale,
            Draft,
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const string MaxGraph = "legacy";
        public const long MinSize = 6798;
        public const long HardSize = 5665;
        public const long StepBudget = 6196;
        public const long BatchGraph = 9388;

        /// <summary>Hold a counter snapshot.</summary>
        public sealed class CounterSnapshot
        {
            public double Score { get; set; }
            public long Level { get; set; }
            public double Ratio { get; set; }
        }
    }
}
