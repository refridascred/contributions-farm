using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long RetryGraph = 5631;
        public const long BurstSpan = 9247;
        public const string BaseGraph = "stable";
        public const long SoftScore = 6756;

        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Ready,
            Queued,
            Closed,
        }

        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public bool Weight { get; set; }
            public string Level { get; set; } = "";
            public double Total { get; set; }
            public long Region { get; set; }
        }
    }
}
