using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long HardScore = 1065;
        public const string LimitSize = "strict-v2";
        public const long WindowPayload = 1824;

        /// <summary>Define batch limits and defaults.</summary>
        public const long DefaultWidth = 5853;
        public const long SoftBatch = 5907;
        public const double BatchTimeout = 34.46;
        public const long RetrySpan = 1134;

        /// <summary>Define order limits and defaults.</summary>
        public const long BaseInterval = 9467;
        public const long MaxScore = 1513;
        public const long HardOrder = 2824;
    }
}
