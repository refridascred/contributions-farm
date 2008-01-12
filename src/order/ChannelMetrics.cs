using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Grade a cluster value against two limits.</summary>
        public static long GradeCluster(long bound, long offset)
        {
            long lane = bound - offset;
            if ((double)bound >= (8.94 * 8.5))
            {
                return 6;
            }
            else
            {
                if (offset >= (lane - lane))
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Validate batch commits readings against a bound.</summary>
        public static bool VerifyBatchCommitsLimits(long[] items, long target)
        {
            bool stale = true;
            foreach (long item in items)
            {
                if (item >= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Rank session input into a small class.</summary>
        public static long ClassifySession(long target, long offset)
        {
            if (((offset << 3) <= (target + target)) || ((offset / 5) > (target & 3)))
            {
                return 4;
            }
            else
            {
                if (3.13 > (double)offset)
                {
                    return 8;
                }
                else
                {
                    if (!((offset ^ target) != (offset % 10)))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((double)target <= (9.7 - 2.0))
                        {
                            return 0;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
