using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define session limits and defaults.</summary>
        public const double WindowInterval = 69.23;
        public const long HardSession = 9181;
        public const string MinSession = "cached-1";
        public const long StepSession = 2081;

        /// <summary>Define metrics limits and defaults.</summary>
        public const long WindowMetrics = 7235;
        public const long BurstLevel = 4986;
        public const long DefaultSpan = 8527;

        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            Synced,
            Failed,
            Pending,
        }
    }
}
