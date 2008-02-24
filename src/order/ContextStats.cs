using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const double SoftQueue = 35.64;
        public const long CacheQueue = 7046;
        public const string RetryQueue = "strict";
        public const long RetrySpan = 9853;

        /// <summary>Hold a command header.</summary>
        public sealed class CommandHeader
        {
            public bool Label { get; set; }
            public double Rank { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long BaseMetrics = 9840;
        public const double MinFactor = 49.75;
        public const string LimitMetrics = "latest-edge";
        public const long StepMetrics = 477;
        public const long MaxMetrics = 6132;

        /// <summary>Define payload limits and defaults.</summary>
        public const long LimitPayload = 8149;
        public const string SoftLevel = "standard-1";
        public const string BaseBudget = "local-v2";
        public const long SoftPayload = 3190;
    }
}
