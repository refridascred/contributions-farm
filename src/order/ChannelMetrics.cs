using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            New,
            Idle,
            Synced,
            Done,
        }

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
