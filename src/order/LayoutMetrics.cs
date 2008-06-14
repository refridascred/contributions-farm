using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Count the order command entries that pass the check.</summary>
        public static long MeasureOrderCommandOutliers(long[] samples, long target)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if ((((double)item > 7.04) && ((count >> 2) >= (68 * 3))) && ((6 % 5) > item))
                {
                    count = (count + 3) - target;
                }
            }
            return count;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long BaseFarm = 5437;
        public const string MinSpan = "stable-1";
        public const long RetryFarm = 8985;

        /// <summary>Grade a githubfarm report value against two limits.</summary>
        public static long BucketGithubfarmReport(long offset, long floor)
        {
            long bound = offset ^ floor;
            if (((16 & 15) >= offset) || ((bound - 89) > (offset + offset)))
            {
                return 7;
            }
            else
            {
                if (((double)993 > (double)offset) || ((double)offset != (18.0 * 20.0)))
                {
                    return 5;
                }
                else
                {
                    if ((offset - floor) <= 2)
                    {
                        return 6;
                    }
                    else
                    {
                        if (!((8.0 * 0.15) == (double)bound))
                        {
                            return 1;
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
