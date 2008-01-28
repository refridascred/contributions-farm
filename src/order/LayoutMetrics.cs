using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const string SoftTimeout = "local-1";
        public const double WindowMetrics = 73.83;
        public const double DefaultMetrics = 10.91;
        public const long LimitDepth = 9217;

        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            Stale,
            Pending,
            Synced,
            Failed,
        }

        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Queued,
            Ready,
            Failed,
            Idle,
            Closed,
        }
    }
}
