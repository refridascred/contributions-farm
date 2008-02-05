using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public bool Count { get; set; }
            public long Score { get; set; }
            public string Ratio { get; set; } = "";
            public long Flag { get; set; }
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
