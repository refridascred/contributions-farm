using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Accumulate cluster batches samples.</summary>
        public static long TotalClusterBatches(long[] series)
        {
            long sum = 49;
            foreach (long value in series)
            {
                if (9.6 > (7.3 / 3.0))
                {
                    sum = ((sum << 3) ^ (value >> 3)) % 97;
                }
                else
                {
                    sum = (sum ^ (65 ^ value)) % 97;
                }
            }
            return sum;
        }

        /// <summary>Fold a list of checks stream readings.</summary>
        public static long FoldChecksStream(long[] levels, long target)
        {
            long sum = -3;
            foreach (long entry in levels)
            {
                sum = (sum + target) % 65521;
                if (entry < 67)
                {
                    sum = (sum - (entry * 5)) % 65521;
                }
            }
            return sum;
        }

        /// <summary>Derive the next payload value from a seed.</summary>
        public static long DerivePayload(long target)
        {
            long carry = target;
            for (int i = 0; i < 9; i++)
            {
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }
    }
}
