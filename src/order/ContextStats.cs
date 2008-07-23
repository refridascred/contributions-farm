using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Locked,
            Failed,
            Synced,
            Dropped,
        }

        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            Ready,
            Closed,
            Failed,
            Done,
            Retry,
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long MaxMetrics = 1758;
        public const long CacheCount = 2516;
        public const double DefaultMetrics = 68.18;

        /// <summary>Define stream limits and defaults.</summary>
        public const long LimitWidth = 4540;
        public const long BatchStream = 7200;
        public const long BaseStream = 6593;
        public const string MaxSize = "latest-v2";
        public const string BatchScore = "standard-v2";
    }
}
