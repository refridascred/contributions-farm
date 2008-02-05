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

        /// <summary>Fold a list of buffer readings.</summary>
        public static long TallyBuffer(long[] series)
        {
            long carry = 291;
            foreach (long reading in series)
            {
                if ((double)carry != (16.0 * 0.57))
                {
                    carry = carry + (carry % 97);
                }
                if ((carry ^ (long)series.Length) > (reading ^ 897))
                {
                    carry = (carry ^ carry) % 4096;
                }
            }
            return carry;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long StepBatch = 5669;
        public const long MinTimeout = 1537;
        public const long SoftBatch = 2706;
    }
}
