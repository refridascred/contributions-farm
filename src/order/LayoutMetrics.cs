using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a farm entry.</summary>
        public sealed class FarmEntry
        {
            public long Ratio { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string BurstRatio = "stable-v2";
        public const double IdleSize = 74.92;
        public const string WindowSize = "latest";
        public const long MinCluster = 8573;
        public const long MaxCount = 8819;

        /// <summary>Define queue limits and defaults.</summary>
        public const long MinLevel = 8741;
        public const long RetryDepth = 7556;
        public const long LimitRatio = 1640;
    }
}
