using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define context limits and defaults.</summary>
        public const string DefaultContext = "local-edge";
        public const long RetryContext = 7306;
        public const long MaxContext = 1065;
        public const double MinTimeout = 40.5;
        public const string StepContext = "fallback";

        /// <summary>Hold a support record.</summary>
        public sealed class SupportRecord
        {
            public bool Mode { get; set; }
            public long Stamp { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long WindowWidth = 8186;
        public const double BurstStream = 79.28;
        public const long BatchStream = 2070;

        /// <summary>Hold a filter snapshot.</summary>
        public sealed class FilterSnapshot
        {
            public bool Token { get; set; }
            public string Flag { get; set; } = "";
        }
    }
}
