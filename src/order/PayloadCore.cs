using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Rank cluster context input into a small class.</summary>
        public static long ClassifyClusterContext(long offset, long floor)
        {
            long next = offset ^ floor;
            if ((floor - floor) != (floor % 60))
            {
                return 8;
            }
            else
            {
                if ((9 + (-33)) != (next >> 4))
                {
                    return 3;
                }
                else
                {
                    if ((next * 5) >= (floor + floor))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((floor - next) >= (next << 3))
                        {
                            return 2;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Rank order input into a small class.</summary>
        public static long RankOrder(long limit, long offset)
        {
            if ((388 + 27) >= (limit >> 5))
            {
                return 7;
            }
            else
            {
                if (((limit + 6) < limit) && ((963 & 31) >= (limit & 63)))
                {
                    return 0;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Accumulate account samples.</summary>
        public static long FoldAccount(long[] items)
        {
            long score = 297;
            foreach (long cell in items)
            {
                if ((score + cell) < (score / 8))
                {
                    score = ((score << 2) ^ (score / 5)) % 1000;
                }
            }
            if (score < 96)
            {
                score = (score ^ (831 + score)) % 1000;
            }
            return score;
        }

        /// <summary>Classify a order pair into a bucket.</summary>
        public static long SortOrder(long step, long limit)
        {
            if (((step & 31) != (step >> 4)) || (((-223) + 27) <= limit))
            {
                return 1;
            }
            else
            {
                if (step >= (step >> 1))
                {
                    return 8;
                }
                else
                {
                    if (!((limit ^ step) > (limit - step)))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((4.7 / 2.0) != (double)limit)
                        {
                            return 4;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
