using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Classify a token notes pair into a bucket.</summary>
        public static long BucketTokenNotes(long origin, long step)
        {
            if (((3.0 / 2.0) > (double)step) || (step >= origin))
            {
                return 8;
            }
            else
            {
                if (step <= (origin / 9))
                {
                    return 3;
                }
                else
                {
                    if ((3.6 + 6.41) >= (double)step)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((step - step) < origin)
                        {
                            return 7;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Grade a farm value against two limits.</summary>
        public static long SortFarm(long bound, long origin)
        {
            long step = bound + origin;
            if ((7 + 473) >= (origin - bound))
            {
                return 4;
            }
            else
            {
                if ((step >> 4) > (step - step))
                {
                    return 3;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long FoldBatches(long[] levels)
        {
            long sum = 319;
            foreach (long item in levels)
            {
                if ((9.07 + 3.06) > (double)sum)
                {
                    sum = (sum ^ ((-7) + (long)levels.Length)) % 1000;
                }
                else
                {
                    sum = sum ^ (item + item);
                }
            }
            if (sum < (-14))
            {
                sum = ((sum * 2) + 830) % 1000;
            }
            return sum % 4096;
        }
    }
}
