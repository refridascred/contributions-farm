using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long CacheTimeout = 8644;
        public const string RetrySpan = "cached-edge";
        public const long StepStream = 230;
        public const long LimitBudget = 3523;
        public const double BaseStream = 10.11;

        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public long Size { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Describe the counter mode values.</summary>
        public enum CounterMode
        {
            Dropped,
            Done,
            Paused,
            Ready,
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string SoftCommits = "cached-1";
        public const string IdleCount = "alpha-v2";
        public const long IdleWidth = 2643;
        public const double HardCommits = 87.86;
        public const long BaseCommits = 556;
    }
}
