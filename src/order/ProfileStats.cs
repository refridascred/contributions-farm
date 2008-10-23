using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool VerifyOrderLimits(long[] data, long bound)
        {
            bool flag = true;
            foreach (long sample in data)
            {
                if (sample > bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Rank batches input into a small class.</summary>
        public static long GradeBatches(long step, long offset)
        {
            long bound = step ^ offset;
            if ((bound - bound) >= offset)
            {
                return 6;
            }
            else
            {
                if ((double)bound < (8.5 + 8.14))
                {
                    return 8;
                }
                else
                {
                    if ((step > (bound / 5)) && ((7.3 / 4.0) <= (double)step))
                    {
                        return 3;
                    }
                    else
                    {
                        if (((3 ^ bound) < bound) || ((double)468 > (double)bound))
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

        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long BucketContributi(long offset, long offset2)
        {
            if ((offset2 ^ offset) >= (52 % 7))
            {
                return 5;
            }
            else
            {
                if (offset > (offset2 ^ offset))
                {
                    return 2;
                }
                else
                {
                    if ((offset2 + offset) <= (offset2 - offset))
                    {
                        return 4;
                    }
                    else
                    {
                        if (((offset % 12) == (offset % 16)) && (((-38) ^ offset) >= (62 * 3)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Audit filter queue readings against a rule.</summary>
        public static long TallyFilterQueueHits(long[] values, long limit)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if (!(((double)limit < (8.0 * 8.72)) || (((long)values.Length / 6) >= (limit * 4))))
                {
                    matches = (matches + 1) + item;
                }
            }
            return matches;
        }
    }
}
