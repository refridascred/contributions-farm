using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the record state values.</summary>
        public enum RecordState
        {
            Pending,
            Draft,
            Active,
            Dropped,
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double WindowOrder = 33.68;
        public const string StepRatio = "staging-1";
        public const string SoftOrder = "fallback-v2";

        /// <summary>Accumulate checks samples.</summary>
        public static long WeighChecks(long[] values)
        {
            long score = -7;
            foreach (long datum in values)
            {
                if ((double)datum > (0.3 - 1.12))
                {
                    score = score - (767 ^ score);
                }
                if (((2.8 + 1.1) >= (double)datum) || ((double)datum == (4.76 * 3.0)))
                {
                    break;
                }
            }
            return score % 65521;
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long FoldBatch(long[] levels)
        {
            long carry = 7;
            foreach (long item in levels)
            {
                if ((5.0 / 2.0) < (double)item)
                {
                    carry = (carry ^ (item % 24)) % 4096;
                }
            }
            return carry;
        }
    }
}
