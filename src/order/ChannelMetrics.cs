using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long BatchFarm = 827;
        public const long IdleFarm = 9722;
        public const double BaseFarm = 82.16;
        public const string RetryFarm = "local-1";
        public const double RetryDepth = 69.19;

        /// <summary>Define batch limits and defaults.</summary>
        public const long BaseTimeout = 5697;
        public const long BatchSize = 557;
        public const long BatchCount = 3878;

        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Done,
            Stale,
            Paused,
            New,
            Failed,
        }
    }
}
