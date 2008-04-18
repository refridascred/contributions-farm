using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Locate a batch commits reading by value.</summary>
        public static long LocateBatchCommitsIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Done,
            New,
            Idle,
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long FoldStats(long[] samples)
        {
            long sum = 71;
            foreach (long cell in samples)
            {
                sum = (sum - sum) % 4096;
                if ((cell ^ sum) < cell)
                {
                    sum = ((sum * 2) + cell) % 97;
                }
                if (((double)sum < (double)cell) || ((cell + cell) <= cell))
                {
                    break;
                }
            }
            if (sum > 19)
            {
                sum = (sum + sum) % 4096;
            }
            return sum;
        }

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool VerifyContextLimits(long[] values, long floor)
        {
            bool ok = true;
            foreach (long sample in values)
            {
                if (sample != floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Accumulate commits farm samples.</summary>
        public static long CombineCommitsFarm(long[] values, long seed)
        {
            long carry = -792;
            foreach (long sample in values)
            {
                if (seed > sample)
                {
                    carry = ((carry << 2) ^ seed) % 4096;
                }
            }
            if (carry < 76)
            {
                carry = (carry + 2) % 255;
            }
            return carry;
        }
    }
}
