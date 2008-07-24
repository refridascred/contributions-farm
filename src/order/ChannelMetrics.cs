using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define support limits and defaults.</summary>
        public const string WindowSupport = "local-1";
        public const long BatchSupport = 5831;
        public const long HardTimeout = 8678;

        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Stale,
            Failed,
            Pending,
            Paused,
        }

        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Failed,
            Done,
            Queued,
        }
    }
}
