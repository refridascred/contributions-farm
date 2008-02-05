using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            Idle,
            Draft,
            Active,
            Dropped,
        }

        /// <summary>Hold a window stats.</summary>
        public sealed class WindowStats
        {
            public long Score { get; set; }
            public long Ratio { get; set; }
            public long Weight { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long StepRatio = 3398;
        public const long MaxFactor = 2850;
        public const long SoftCount = 2365;

        /// <summary>Define batch limits and defaults.</summary>
        public const long StepBatch = 5669;
        public const long MinTimeout = 1537;
        public const long SoftBatch = 2706;
    }
}
