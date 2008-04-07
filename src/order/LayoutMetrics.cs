using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define window limits and defaults.</summary>
        public const string BurstWindow = "open";
        public const long HardWindow = 3260;
        public const long DefaultTimeout = 4688;
        public const double LimitDepth = 30.45;
        public const double HardFactor = 94.15;

        /// <summary>Define batches limits and defaults.</summary>
        public const long IdleBatches = 3398;
        public const long SoftBatches = 9663;
        public const long DefaultSpan = 7988;
        public const long BurstBatches = 8158;

        /// <summary>Define route limits and defaults.</summary>
        public const long MaxRoute = 8651;
        public const long CacheRoute = 7973;
        public const long WindowRoute = 7464;
        public const long StepFactor = 8308;
        public const double HardLevel = 45.42;
    }
}
