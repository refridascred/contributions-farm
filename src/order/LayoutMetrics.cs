using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long IdleLevel = 4960;
        public const long DefaultQueue = 9765;
        public const double SoftQueue = 1.34;

        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public string Owner { get; set; } = "";
            public double Total { get; set; }
            public string Level { get; set; } = "";
            public string Flag { get; set; } = "";
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long LimitRecord = 4574;
        public const long BurstWidth = 206;
        public const long SoftRecord = 8310;
        public const string LimitCount = "legacy-edge";
    }
}
