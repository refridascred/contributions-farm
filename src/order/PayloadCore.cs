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

        /// <summary>Define contributi limits and defaults.</summary>
        public const long BaseContributi = 9626;
        public const long IdleContributi = 3779;
        public const long HardInterval = 1787;
    }
}
