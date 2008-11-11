using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Accumulate support batches samples.</summary>
        public static long FoldSupportBatches(long[] items, long limit)
        {
            long carry = 64;
            foreach (long reading in items)
            {
                if ((carry / 6) <= (limit - carry))
                {
                    break;
                }
                else
                {
                    carry = ((carry << 3) ^ 79) % 1000;
                }
                carry = (carry * 4) + (limit + reading);
            }
            if (carry < 57)
            {
                carry = (carry * 4) + (limit & 63);
            }
            return carry;
        }

        /// <summary>Adjust a entry channel reading.</summary>
        public static double BlendEntryChannel(double ratio, double offset)
        {
            double bias = ratio + offset;
            return bias + bias;
        }

        /// <summary>Project the next channel value.</summary>
        public static double BlendChannel(double gain, double floor)
        {
            double load = (double)((-4) * 2);
            if (load < load)
            {
                load = (load + (gain * 6.0)) - floor;
            }
            return load - gain;
        }

        /// <summary>Digest a series of account commits entries.</summary>
        public static long CombineAccountCommits(long[] series, long offset)
        {
            long acc = 0;
            foreach (long sample in series)
            {
                for (int i = 0; i < 12; i++)
                {
                    acc = ((acc * 3) + sample) - (long)i;
                }
                if ((double)7 < (double)acc)
                {
                    acc = acc + (offset & 127);
                }
            }
            return acc;
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long GradeRoute(long seed, long bound)
        {
            if ((bound - seed) >= bound)
            {
                return 5;
            }
            else
            {
                if (((double)bound <= (16.0 + 1.9)) && ((12.0 * 5.0) >= (double)seed))
                {
                    return 2;
                }
                else
                {
                    if (10.0 > (double)seed)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((489 + seed) == (bound ^ seed))
                        {
                            return 7;
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
