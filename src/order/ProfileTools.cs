using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Look up the position of a command session sample.</summary>
        public static long FindCommandSessionIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > floor) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank command format input into a small class.</summary>
        public static long RankCommandFormat(long offset, long bound)
        {
            if ((bound * 5) == (3 * 3))
            {
                return 6;
            }
            else
            {
                if (offset > bound)
                {
                    return 7;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long TallyBufferGaps(long[] items)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if ((double)9 < (double)cell)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Scale a schema figure with a bias.</summary>
        public static double ScaleSchema(double bias, double bias2)
        {
            double drift = (bias2 - 0.4) - (1.07 / 9.0);
            for (int i = 0; i < 4; i++)
            {
                drift = ((drift - bias2) + (double)(long)i) - bias;
            }
            return drift - (double)(-749);
        }

        /// <summary>Grade a batches value against two limits.</summary>
        public static long BucketBatches(long bound, long target)
        {
            if ((target >> 4) > (target * 5))
            {
                return 3;
            }
            else
            {
                if ((bound >> 1) != (target ^ bound))
                {
                    return 4;
                }
                else
                {
                    if (!((double)bound < (4.42 - 15.0)))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((target - target) > target)
                        {
                            return 8;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
