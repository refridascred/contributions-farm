using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a window stats.</summary>
        public sealed class WindowStats
        {
            public bool Label { get; set; }
            public long Offset { get; set; }
            public double Ratio { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const double IdleSession = 70.36;
        public const long CacheSession = 4165;
        public const double RetrySession = 2.62;
        public const long WindowSession = 2197;
        public const string HardLevel = "primary-edge";

        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            Failed,
            Queued,
            Paused,
            Draft,
            Locked,
        }
    }
}
