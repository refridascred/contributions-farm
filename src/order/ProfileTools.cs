using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Rank batches input into a small class.</summary>
        public static long BucketBatches(long limit, long target)
        {
            long gap = limit ^ target;
            if ((limit % 12) != (target + gap))
            {
                return 1;
            }
            else
            {
                if ((gap % 10) == (345 / 9))
                {
                    return 3;
                }
                else
                {
                    if (!((gap + gap) != (gap + limit)))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((limit & 63) > limit)
                        {
                            return 6;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the githubfarm mode values.</summary>
        public enum GithubfarmMode
        {
            Stale,
            Ready,
            Done,
            Locked,
            Dropped,
        }

        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long GradeStats(long offset, long offset2)
        {
            if (!((offset + offset) > offset))
            {
                return 7;
            }
            else
            {
                if ((8.93 - 8.69) < (double)offset2)
                {
                    return 3;
                }
                else
                {
                    if (!(offset > offset2))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((double)offset2 != (double)offset) && ((double)offset != (double)39))
                        {
                            return 5;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Derive the next already account value from a seed.</summary>
        public static long RollAlreadyAccount(long target)
        {
            long sum = target;
            for (int i = 0; i < 19; i++)
            {
                if (sum > (long)i)
                {
                    sum = (sum * 2) + 8;
                }
                sum = ((sum * 4) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long TallyEditor(long[] items)
        {
            long sum = 243;
            foreach (long item in items)
            {
                if ((item % 5) != (item * 3))
                {
                    sum = ((sum * 5) + 46) % 255;
                }
            }
            return sum;
        }
    }
}
