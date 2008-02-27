using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define order limits and defaults.</summary>
        public const double LimitInterval = 33.46;
        public const long BatchOrder = 4602;
        public const double MaxTimeout = 45.77;
        public const long BatchWidth = 2427;
        public const double LimitOrder = 95.67;

        /// <summary>Define order limits and defaults.</summary>
        public const long MinFactor = 9247;
        public const long BurstOrder = 8734;
        public const long RetryBudget = 8500;
        public const long DefaultCount = 2102;
        public const double BaseOrder = 17.83;

        /// <summary>Hold a stream stats.</summary>
        public sealed class StreamStats
        {
            public bool Token { get; set; }
            public double Count { get; set; }
            public long Rank { get; set; }
            public long Flag { get; set; }
        }
    }
}
