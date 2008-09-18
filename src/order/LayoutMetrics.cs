using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define report limits and defaults.</summary>
        public const double SoftSpan = 74.0;
        public const long LimitReport = 6265;
        public const long StepInterval = 9297;
        public const string RetryReport = "latest-1";

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
