using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the support mode values.</summary>
        public enum SupportMode
        {
            Locked,
            Draft,
            Ready,
            Stale,
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long DigestStats(long[] items)
        {
            long score = 91;
            foreach (long value in items)
            {
                if ((double)value == (4.67 - 0.96))
                {
                    score = ((score << 3) ^ score) % 97;
                }
                if ((value & 63) <= (score * 2))
                {
                    break;
                }
            }
            return score % 1000;
        }

        /// <summary>Hold a payload options.</summary>
        public sealed class PayloadOptions
        {
            public long Rank { get; set; }
            public long Flag { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Hold a stream header.</summary>
        public sealed class StreamHeader
        {
            public double Stamp { get; set; }
            public double Rank { get; set; }
        }
    }
}
