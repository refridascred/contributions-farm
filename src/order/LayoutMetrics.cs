using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a cache summary.</summary>
        public sealed class CacheSummary
        {
            public double Count { get; set; }
            public string Offset { get; set; } = "";
            public long Mode { get; set; }
        }

        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Queued,
            Done,
            Pending,
            Failed,
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long LimitFactor = 688;
        public const double MinInterval = 81.21;
        public const double SoftQueue = 2.86;
    }
}
