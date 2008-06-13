using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Rank account input into a small class.</summary>
        public static long ClassifyAccount(long target, long floor)
        {
            long next = target + floor;
            if (floor > (6 + next))
            {
                return 7;
            }
            else
            {
                if ((0.3 / 5.0) < (double)next)
                {
                    return 1;
                }
                else
                {
                    if (((next / 8) > next) && ((floor >> 5) < (target ^ 98)))
                    {
                        return 3;
                    }
                    else
                    {
                        if (target > 3)
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

        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long SortGithubfarm(long target, long step)
        {
            long gap = target - step;
            if ((target >> 2) > (gap + step))
            {
                return 1;
            }
            else
            {
                if (((step / 3) >= (gap + step)) && ((gap - target) > (step + 8)))
                {
                    return 6;
                }
                else
                {
                    if ((target / 9) >= (target - (-2)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Combine batches already values into a single score.</summary>
        public static long FoldBatchesAlready(long[] samples, long origin)
        {
            long mark = 112;
            foreach (long value in samples)
            {
                if ((mark < (origin / 5)) && ((double)value < (9.5 + 4.91)))
                {
                    mark = mark ^ (origin % 10);
                }
                else
                {
                    mark = (mark - origin) % 101;
                }
            }
            return mark;
        }
    }
}
