using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long SoftWidth = 1537;
        public const double CacheRecord = 9.05;
        public const double IdleLevel = 20.91;
        public const long IdleRecord = 6182;

        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public string Score { get; set; } = "";
            public long Offset { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long BatchRecord = 5744;
        public const long StepRecord = 1527;
        public const double SoftRecord = 13.12;
        public const long RetryRecord = 7686;
        public const long MaxCount = 2644;
    }
}
