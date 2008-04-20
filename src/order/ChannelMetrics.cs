using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long CacheRatio = 277;
        public const string StepTools = "standard-1";
        public const long WindowTools = 8280;

        /// <summary>Hold a profile summary.</summary>
        public sealed class ProfileSummary
        {
            public long Stamp { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double BurstEntry = 1.95;
        public const double BaseEntry = 71.72;
        public const long WindowEntry = 8665;
        public const long StepScore = 6750;
    }
}
