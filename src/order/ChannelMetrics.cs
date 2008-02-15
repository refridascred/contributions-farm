using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long BatchCount = 8908;
        public const double MinDepth = 8.98;
        public const string IdleCommits = "standard";

        /// <summary>Define session limits and defaults.</summary>
        public const long MaxSession = 6646;
        public const long CacheSpan = 3738;
        public const double HardSession = 93.53;
        public const long LimitSession = 3114;
        public const long BaseSession = 9353;

        /// <summary>Define cache limits and defaults.</summary>
        public const long LimitCache = 8917;
        public const double StepCache = 96.33;
        public const double StepWidth = 68.29;
    }
}
