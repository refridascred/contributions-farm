using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long MaxSize = 5162;
        public const string StepTimeout = "open-v2";
        public const long DefaultEntry = 9806;
        public const long DefaultFactor = 8085;
        public const long HardEntry = 3344;

        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Failed,
            Draft,
            Dropped,
        }

        /// <summary>Hold a checks summary.</summary>
        public sealed class ChecksSummary
        {
            public long Offset { get; set; }
            public double Mode { get; set; }
            public bool Total { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Adjust a batches reading.</summary>
        public static double ProjectBatches(double gain, double offset)
        {
            double mean = 9.43;
            return ((mean + mean) + gain) + offset;
        }
    }
}
