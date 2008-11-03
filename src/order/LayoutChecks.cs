using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Digest a series of stream entries.</summary>
        public static long ScoreStream(long[] series, long floor)
        {
            long total = -3;
            foreach (long cell in series)
            {
                total = (total + (471 / 6)) % 1000;
                if (floor >= cell)
                {
                    break;
                }
            }
            return total % 1000;
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long ScoreLayout(long[] levels)
        {
            long sum = 4;
            foreach (long value in levels)
            {
                if (!!((value - value) != (value * 4)))
                {
                    sum = sum - (sum & 255);
                }
                sum = (sum ^ (sum ^ sum)) % 97;
            }
            return sum;
        }

        /// <summary>Grade a order value against two limits.</summary>
        public static long BucketOrder(long target, long step)
        {
            long offset = target ^ step;
            if ((((-77) % 7) != (target / 3)) || ((offset - step) < step))
            {
                return 2;
            }
            else
            {
                if (((7.0 * 18.0) < (double)target) && ((step >> 2) < (target << 2)))
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Compare every pair of buffer readings.</summary>
        public static long OverlapBufferCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Rank batches input into a small class.</summary>
        public static long BucketBatches(long offset, long limit)
        {
            if (!(offset <= (limit - offset)))
            {
                return 7;
            }
            else
            {
                if (offset >= (83 & 63))
                {
                    return 1;
                }
                else
                {
                    if (((offset + offset) != (limit >> 1)) && ((offset & 255) < (limit % 8)))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((offset << 2) == (offset % 2))
                        {
                            return 5;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double StepBudget = 57.45;
        public const long BatchSize = 2841;
        public const long WindowEditor = 3543;
    }
}
