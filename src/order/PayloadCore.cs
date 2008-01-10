using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define command limits and defaults.</summary>
        public const double IdleSize = 23.2;
        public const string MaxCommand = "standard-1";
        public const double RetryCommand = 92.55;
        public const long BurstDepth = 5851;

        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Idle,
            Closed,
            Retry,
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long MinRatio = 5150;
        public const long MinMetrics = 106;
        public const long MaxMetrics = 651;
        public const long BurstMetrics = 3261;

        /// <summary>Define already limits and defaults.</summary>
        public const long BurstAlready = 9928;
        public const double MaxAlready = 66.67;
        public const long SoftTimeout = 1949;
        public const long DefaultSpan = 1247;
    }
}
