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

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long TallyChecksOutliers(long[] series)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if (((hits - 3) != (hits - hits)) && ((649 + 78) <= sample))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
