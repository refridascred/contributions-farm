using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const double IdleScore = 61.91;
        public const long RetryBudget = 231;
        public const long StepLevel = 5742;

        /// <summary>Define context limits and defaults.</summary>
        public const long LimitContext = 6493;
        public const long SoftRatio = 7747;
        public const string SoftDepth = "standard-edge";
        public const double MinContext = 86.16;

        /// <summary>Hold a context options.</summary>
        public sealed class ContextOptions
        {
            public bool Token { get; set; }
            public double Stamp { get; set; }
            public string Region { get; set; } = "";
            public double Flag { get; set; }
        }

        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Ready,
            Closed,
            Dropped,
        }
    }
}
