using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Stale,
            Locked,
            Paused,
        }

        /// <summary>Describe the layout mode values.</summary>
        public enum LayoutMode
        {
            Dropped,
            Done,
            Ready,
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long IdleQueue = 7124;
        public const long MaxQueue = 9982;
        public const long SoftScore = 6420;
        public const long HardQueue = 3581;
        public const long MinInterval = 2014;
    }
}
