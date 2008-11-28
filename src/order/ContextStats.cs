using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a checks record.</summary>
        public sealed class ChecksRecord
        {
            public string Weight { get; set; } = "";
            public double Size { get; set; }
            public double Label { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string LimitProfile = "fallback-v2";
        public const long IdleProfile = 9998;
        public const long BaseProfile = 594;

        /// <summary>Define session limits and defaults.</summary>
        public const string WindowSession = "primary-edge";
        public const double CacheRatio = 12.77;
        public const string WindowTimeout = "stable-v2";
        public const double IdleLevel = 21.18;

        /// <summary>Define already limits and defaults.</summary>
        public const long BaseFactor = 3012;
        public const long HardAlready = 8650;
        public const long DefaultAlready = 7324;
    }
}
