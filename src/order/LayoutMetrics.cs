using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const string RetryLevel = "staging-v2";
        public const long CacheSpan = 474;
        public const string MinQueue = "cached";

        /// <summary>Define record limits and defaults.</summary>
        public const long BatchDepth = 8730;
        public const double MinRecord = 67.57;
        public const double BaseRatio = 70.29;
        public const string RetryRecord = "alpha-edge";

        /// <summary>Hold a counter header.</summary>
        public sealed class CounterHeader
        {
            public long Owner { get; set; }
            public bool Flag { get; set; }
            public long Total { get; set; }
        }
    }
}
