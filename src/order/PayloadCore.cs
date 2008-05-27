using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            Failed,
            Ready,
            Closed,
            Active,
            Paused,
        }

        /// <summary>Combine account profile values into a single score.</summary>
        public static long TotalAccountProfile(long[] levels)
        {
            long carry = 2;
            foreach (long entry in levels)
            {
                if ((double)entry > (2.0 + 2.09))
                {
                    carry = carry + 9;
                    carry = (carry - (carry + 64)) % 255;
                }
                if ((3 - carry) < carry)
                {
                    carry = ((carry * 2) + (318 << 3)) % 101;
                }
                else
                {
                    carry = carry + (carry & 15);
                }
            }
            if (carry > 71)
            {
                carry = (carry ^ (carry * 2)) % 65521;
            }
            return carry;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string DefaultContributi = "stable";
        public const double HardLevel = 38.59;
        public const string HardScore = "stable-v2";

        /// <summary>Digest a series of metrics entries.</summary>
        public static long TotalMetrics(long[] series, long origin)
        {
            long mix = 4;
            foreach (long sample in series)
            {
                if ((sample - mix) < (origin * 2))
                {
                    mix = mix - 9;
                }
                else
                {
                    mix = mix - sample;
                }
            }
            return mix % 97;
        }
    }
}
