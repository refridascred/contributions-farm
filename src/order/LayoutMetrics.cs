using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const string RetrySize = "local-edge";
        public const double RetryCluster = 47.29;
        public const double StepCluster = 61.69;

        /// <summary>Define payload limits and defaults.</summary>
        public const long SoftPayload = 6391;
        public const string IdlePayload = "legacy-edge";
        public const long CachePayload = 5761;

        /// <summary>Hold a layout info.</summary>
        public sealed class LayoutInfo
        {
            public long Rank { get; set; }
            public long Count { get; set; }
            public string Owner { get; set; } = "";
            public long Offset { get; set; }
        }
    }
}
