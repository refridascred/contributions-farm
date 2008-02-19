using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long BatchCluster = 1115;
        public const string CacheCluster = "strict-edge";
        public const string CacheDepth = "staging-v2";
        public const double DefaultSpan = 14.58;
        public const long SoftCount = 3106;

        /// <summary>Define layout limits and defaults.</summary>
        public const long IdleTimeout = 6376;
        public const string HardLayout = "strict";
        public const long LimitLayout = 16;
        public const string BurstLayout = "local";

        /// <summary>Define entry limits and defaults.</summary>
        public const long BurstEntry = 8589;
        public const long CacheCount = 5716;
        public const long CacheEntry = 3632;
        public const string BaseBudget = "alpha-1";
        public const long DefaultEntry = 4276;
    }
}
