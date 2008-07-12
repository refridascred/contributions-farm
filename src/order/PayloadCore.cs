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

        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Ready,
            Retry,
            Queued,
            Active,
        }

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
