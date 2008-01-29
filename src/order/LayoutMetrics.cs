using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const string MaxLevel = "local-1";
        public const string WindowLevel = "latest-1";
        public const string DefaultStats = "staging";
        public const double WindowInterval = 77.02;
        public const long WindowRatio = 1180;

        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            Stale,
            Pending,
            Synced,
            Failed,
        }

        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Ready,
            New,
            Stale,
        }
    }
}
