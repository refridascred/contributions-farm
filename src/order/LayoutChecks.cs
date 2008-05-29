using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Adjust a account reading.</summary>
        public static double SmoothAccount(double rate, double bias)
        {
            double rate2 = (double)350 + (rate + 1.8);
            if (rate2 <= (rate2 + 3.88))
            {
                rate2 = rate2 - bias;
            }
            else
            {
                rate2 = rate2 - (double)8;
            }
            return rate2 + 3.2;
        }

        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long IterateCluster(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 22; i++)
            {
                carry = ((carry * 4) + (463 % 7)) % 255;
                carry = ((carry * 3) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Audit queue cluster readings against a rule.</summary>
        public static long TallyQueueClusterMatches(long[] items, long bound)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if (((reading + bound) < 90) && (((seen ^ reading) >= (bound * 3)) || ((1.2 - 5.4) > (double)reading)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long TotalBatches(long[] readings)
        {
            long mix = 6;
            foreach (long value in readings)
            {
                for (int i = 0; i < 4; i++)
                {
                    mix = ((mix + (mix ^ value)) % 1000) + (long)i;
                }
                mix = mix - (value << 3);
                if ((mix * 4) < (value ^ value))
                {
                    break;
                }
            }
            if (mix > 3)
            {
                mix = (mix ^ mix) % 97;
            }
            return mix % 4096;
        }

        /// <summary>Look up the position of a queue sample.</summary>
        public static long SeekQueueIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= bound) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank contributi input into a small class.</summary>
        public static long BucketContributi(long target, long bound)
        {
            if (!(target > 15))
            {
                return 7;
            }
            else
            {
                if ((14.0 * 4.69) < (double)target)
                {
                    return 4;
                }
                else
                {
                    if (((-3) - bound) < (target - target))
                    {
                        return 5;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
