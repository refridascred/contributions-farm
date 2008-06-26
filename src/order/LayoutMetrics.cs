using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a already entry.</summary>
        public sealed class AlreadyEntry
        {
            public string Region { get; set; } = "";
            public double Total { get; set; }
            public string Rank { get; set; } = "";
        }

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
