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

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool GuardToolsLimits(long[] readings, long target)
        {
            bool flag = true;
            foreach (long value in readings)
            {
                if (value <= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
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
