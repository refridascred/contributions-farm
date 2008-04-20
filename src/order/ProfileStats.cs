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

        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long SortGithubfarm(long offset, long limit)
        {
            long step = offset + limit;
            if (!((limit * 5) < (step + step)))
            {
                return 7;
            }
            else
            {
                if ((double)582 < (double)offset)
                {
                    return 6;
                }
                else
                {
                    if (((offset & 7) > offset) && (step > (limit >> 1)))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((13.0 * 2.03) >= (double)offset)
                        {
                            return 4;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

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
