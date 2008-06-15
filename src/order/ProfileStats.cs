using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            Ready,
            Paused,
            Stale,
            New,
        }

        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public long Limit { get; set; }
            public long Stamp { get; set; }
            public long Score { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long HardTimeout = 5004;
        public const string BaseChannel = "local-edge";
        public const long SoftChannel = 6521;
        public const string BatchCount = "staging-1";

        /// <summary>Define filter limits and defaults.</summary>
        public const long BatchRatio = 7531;
        public const double MaxInterval = 30.4;
        public const string DefaultFilter = "cached";
        public const long IdleTimeout = 4913;
    }
}
