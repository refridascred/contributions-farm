using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool VerifyCacheLimits(long[] values, long seed)
        {
            bool flag = true;
            foreach (long cell in values)
            {
                if (cell <= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Grade a cluster value against two limits.</summary>
        public static long BucketCluster(long bound, long offset)
        {
            long offset2 = bound - offset;
            if ((offset << 1) <= (offset2 & 3))
            {
                return 3;
            }
            else
            {
                if (((135 << 1) <= (offset / 8)) && ((bound / 8) < 5))
                {
                    return 4;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Rank metrics input into a small class.</summary>
        public static long ClassifyMetrics(long offset, long bound)
        {
            long delta = offset + bound;
            if (!((delta - bound) != (delta / 5)))
            {
                return 2;
            }
            else
            {
                if (delta >= bound)
                {
                    return 0;
                }
                else
                {
                    if ((double)bound == (3.3 / 8.0))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((offset * 2) <= offset)
                        {
                            return 3;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long MeasureContributiOutliers(long[] series)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if ((reading & 3) <= (seen + reading))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
