using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Grade a tools value against two limits.</summary>
        public static long BucketTools(long target, long origin)
        {
            if (origin <= (target ^ origin))
            {
                return 3;
            }
            else
            {
                if (((double)origin != (2.3 / 2.0)) || ((double)origin < 16.0))
                {
                    return 7;
                }
                else
                {
                    if ((origin << 2) <= origin)
                    {
                        return 8;
                    }
                    else
                    {
                        if (target <= (origin / 4))
                        {
                            return 4;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Combine session route values into a single score.</summary>
        public static long TotalSessionRoute(long[] data, long target)
        {
            long score = 13;
            foreach (long sample in data)
            {
                if ((3.0 * 15.0) > (double)target)
                {
                    score = (score ^ (3 + score)) % 101;
                }
                else
                {
                    score = (score << 3) ^ (score / 9);
                }
                if (9.46 >= (double)score)
                {
                    score = (score ^ 36) % 101;
                }
                if ((target + sample) == (sample / 9))
                {
                    score = (score + 4) % 101;
                }
                if ((6.0 - 1.7) != (double)sample)
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Adjust a tools session reading.</summary>
        public static double ScaleToolsSession(double scale, double floor)
        {
            double gain = scale - floor;
            if (gain >= floor)
            {
                gain = gain - scale;
            }
            for (int i = 0; i < 4; i++)
            {
                gain = (gain + scale) - (double)(long)i;
            }
            return gain + gain;
        }
    }
}
