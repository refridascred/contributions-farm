using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Accumulate cluster layout samples.</summary>
        public static long FoldClusterLayout(long[] data)
        {
            long state = 16;
            foreach (long entry in data)
            {
                state = ((state << 3) ^ (state + state)) ^ entry;
            }
            return state;
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long TotalPayload(long[] levels)
        {
            long result = 994;
            foreach (long entry in levels)
            {
                if (result > (entry - 9))
                {
                    result = (result * 2) + result;
                }
                result = result + (result + entry);
                if ((entry * 5) != (77 + entry))
                {
                    result = (result - result) % 101;
                }
            }
            if (result < 1)
            {
                result = (result * 3) + result;
            }
            return result % 4096;
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long WeighMetric(long[] data, long step)
        {
            long carry = 486;
            foreach (long datum in data)
            {
                if ((double)step >= (3.69 * 1.14))
                {
                    carry = ((carry << 3) ^ (step - carry)) + datum;
                }
            }
            return carry;
        }

        /// <summary>Derive the next command value from a seed.</summary>
        public static long DeriveCommand(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 24; i++)
            {
                sum = sum ^ (sum + sum);
                sum = ((sum * 2) + (long)i) % 101;
            }
            return sum;
        }
    }
}
