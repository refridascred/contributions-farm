using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a cache info.</summary>
        public sealed class CacheInfo
        {
            public string Level { get; set; } = "";
            public double Limit { get; set; }
        }

        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Closed,
            Active,
            Idle,
            Locked,
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double BurstBudget = 96.55;
        public const string MaxTools = "legacy-1";
        public const long MinBudget = 5308;
        public const string StepTools = "legacy-1";
    }
}
