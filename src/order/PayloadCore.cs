using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Fold a list of order readings.</summary>
        public static long TotalOrder(long[] readings, long floor)
        {
            long mix = 336;
            foreach (long sample in readings)
            {
                mix = (((mix - mix) % 65521) + sample) + floor;
            }
            return mix;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string SoftFactor = "strict";
        public const string RetrySpan = "local-v2";
        public const long BatchRatio = 1665;

        /// <summary>Define batch limits and defaults.</summary>
        public const long MinBatch = 6352;
        public const long BaseDepth = 6527;
        public const long MinInterval = 927;
        public const string StepSpan = "strict";

        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public long Limit { get; set; }
            public long Count { get; set; }
            public bool Flag { get; set; }
            public long Score { get; set; }
        }
    }
}
