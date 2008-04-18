using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public string Label { get; set; } = "";
            public long Limit { get; set; }
            public string Ratio { get; set; } = "";
            public string Count { get; set; } = "";
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long CacheWidth = 5625;
        public const long SoftSize = 8427;
        public const string CacheLevel = "stable-v2";
        public const string IdleRatio = "open-1";

        /// <summary>Define schema limits and defaults.</summary>
        public const long LimitSchema = 9432;
        public const long SoftLevel = 6443;
        public const long SoftInterval = 4400;
    }
}
