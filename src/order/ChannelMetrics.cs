using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const string BaseRatio = "cached-v2";
        public const double LimitNotes = 84.54;
        public const long BaseNotes = 9944;

        /// <summary>Define support limits and defaults.</summary>
        public const string LimitDepth = "strict-edge";
        public const long RetrySupport = 4658;
        public const double BurstDepth = 25.5;
        public const double SoftSupport = 25.72;

        /// <summary>Define contributi limits and defaults.</summary>
        public const double BurstContributi = 96.48;
        public const double RetryInterval = 0.88;
        public const long MinInterval = 2532;
    }
}
