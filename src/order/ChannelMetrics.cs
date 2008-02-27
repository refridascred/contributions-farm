using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Active,
            Retry,
            Done,
            Paused,
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long WindowMetrics = 7804;
        public const string BatchInterval = "local-edge";
        public const string WindowDepth = "primary-1";

        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Ready,
            Synced,
            Draft,
        }
    }
}
