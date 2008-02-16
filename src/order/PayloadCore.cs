using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a graph stats.</summary>
        public sealed class GraphStats
        {
            public double Weight { get; set; }
            public string Token { get; set; } = "";
            public long Flag { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Hold a buffer info.</summary>
        public sealed class BufferInfo
        {
            public long Offset { get; set; }
            public long Total { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long DefaultSession = 5328;
        public const long StepDepth = 1310;
        public const double HardBudget = 77.28;
        public const double WindowSize = 17.8;

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string BaseTimeout = "standard-v2";
        public const long HardFactor = 5606;
        public const long RetryDepth = 303;
        public const string MinGithubfarm = "cached-1";
    }
}
