using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long BurstMetrics = 331;
        public const long IdleInterval = 1556;
        public const double WindowMetrics = 40.19;
        public const long MinMetrics = 3413;
        public const string SoftFactor = "latest-edge";

        /// <summary>Hold a stats info.</summary>
        public sealed class StatsInfo
        {
            public double Limit { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Hold a entry snapshot.</summary>
        public sealed class EntrySnapshot
        {
            public long Total { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long DefaultAccount = 1070;
        public const string BaseAccount = "open-v2";
        public const long BaseScore = 1309;
        public const long BatchInterval = 4706;
    }
}
