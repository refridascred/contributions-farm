using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long CacheSchema = 8270;
        public const long RetrySchema = 3277;
        public const double DefaultRatio = 68.89;
        public const long BatchInterval = 6004;

        /// <summary>Hold a profile snapshot.</summary>
        public sealed class ProfileSnapshot
        {
            public bool Size { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long StepSession = 8867;
        public const string WindowSession = "strict";
        public const long MinCount = 7500;
    }
}
