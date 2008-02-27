using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long CacheFactor = 8838;
        public const long MinSize = 1311;
        public const long BatchDepth = 7053;
        public const long SoftCounter = 3409;
        public const string LimitCounter = "latest-1";

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
