using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long WindowRatio = 1672;
        public const long BurstCache = 9270;
        public const double SoftFactor = 86.39;
        public const long RetrySize = 9347;
        public const string BurstCount = "staging-1";

        /// <summary>Hold a batch snapshot.</summary>
        public sealed class BatchSnapshot
        {
            public string Count { get; set; } = "";
            public long Offset { get; set; }
            public bool Stamp { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long BatchSize = 2011;
        public const double StepSchema = 48.59;
        public const long WindowSchema = 6360;
    }
}
