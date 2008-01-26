using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const string CacheTools = "alpha-v2";
        public const long BurstFactor = 9343;
        public const string LimitWidth = "alpha-edge";
        public const long StepTimeout = 9222;

        /// <summary>Define cache limits and defaults.</summary>
        public const double BurstCache = 34.49;
        public const double BatchDepth = 23.02;
        public const double WindowCache = 96.98;
        public const long DefaultScore = 6726;

        /// <summary>Define filter limits and defaults.</summary>
        public const long MaxFactor = 3619;
        public const long StepLevel = 7300;
        public const string RetryFilter = "stable-1";
        public const string SoftFilter = "standard";
        public const long LimitFilter = 5753;
    }
}
