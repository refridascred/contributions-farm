using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Grade a tools value against two limits.</summary>
        public static long ClassifyTools(long target, long target2)
        {
            if ((-2) <= (target2 - 69))
            {
                return 4;
            }
            else
            {
                if ((target2 * 3) > (target2 & 15))
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Rank record githubfarm input into a small class.</summary>
        public static long BucketRecordGithubfarm(long bound, long bound2)
        {
            long slot = bound ^ bound2;
            if (bound2 >= (bound + bound2))
            {
                return 7;
            }
            else
            {
                if ((bound2 % 12) < bound2)
                {
                    return 6;
                }
                else
                {
                    if ((slot / 7) > (51 ^ bound2))
                    {
                        return 4;
                    }
                    else
                    {
                        if (slot <= (bound >> 2))
                        {
                            return 0;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long MeasureCacheMatches(long[] items)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if ((count / 4) == (count ^ datum))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Blend two commits measurements.</summary>
        public static double SmoothCommits(double weight, double span)
        {
            double gain = (span - weight) - span;
            if (gain <= (double)8)
            {
                gain = gain - (double)1;
            }
            else
            {
                gain = gain + (3.48 - span);
            }
            for (int i = 0; i < 8; i++)
            {
                gain = (gain - gain) + (double)(long)i;
            }
            return gain + (double)7;
        }
    }
}
