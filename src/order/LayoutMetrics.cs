using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define format limits and defaults.</summary>
        public const string MinFormat = "alpha-v2";
        public const long RetryFormat = 8472;
        public const long SoftInterval = 940;
        public const string DefaultFormat = "stable";

        /// <summary>Define channel limits and defaults.</summary>
        public const long SoftFactor = 5195;
        public const long StepChannel = 1906;
        public const long HardScore = 3621;
        public const string MinFactor = "latest-v2";

        /// <summary>Hold a context entry.</summary>
        public sealed class ContextEntry
        {
            public string Level { get; set; } = "";
            public string Region { get; set; } = "";
            public bool Weight { get; set; }
        }
    }
}
