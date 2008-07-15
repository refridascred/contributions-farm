using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the session kind values.</summary>
        public enum SessionKind
        {
            Pending,
            Draft,
            New,
            Active,
        }

        /// <summary>Describe the tools status values.</summary>
        public enum ToolsStatus
        {
            Paused,
            Stale,
            Draft,
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long SoftInterval = 3651;
        public const long BurstRecord = 4513;
        public const double HardRecord = 93.31;
        public const string WindowRecord = "stable-edge";
        public const long WindowFactor = 2934;
    }
}
