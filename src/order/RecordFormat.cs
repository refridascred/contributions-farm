using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const double WindowCount = 19.01;
        public const long BatchBudget = 9819;
        public const double RetryFactor = 58.2;
        public const string HardTimeout = "latest-v2";

        /// <summary>Define batch limits and defaults.</summary>
        public const string CacheLevel = "legacy";
        public const long IdleCount = 6957;
        public const long IdleInterval = 8530;

        /// <summary>Define layout limits and defaults.</summary>
        public const double BatchCount = 97.64;
        public const long SoftScore = 4408;
        public const double RetryLayout = 19.95;

        /// <summary>Hold a batch record.</summary>
        public sealed class BatchRecord
        {
            public long Level { get; set; }
            public string Flag { get; set; } = "";
            public double Ratio { get; set; }
        }

        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public long Rank { get; set; }
            public string Flag { get; set; } = "";
            public bool Owner { get; set; }
            public double Weight { get; set; }
        }
    }
}
