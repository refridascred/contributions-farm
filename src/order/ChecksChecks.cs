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

        /// <summary>Classify a checks githubfarm pair into a bucket.</summary>
        public static long ClassifyChecksGithubfarm(long step, long origin)
        {
            long edge = step - origin;
            if ((step >= (step - edge)) || ((double)origin >= (19.0 / 6.0)))
            {
                return 6;
            }
            else
            {
                if (!(4.34 > (double)edge))
                {
                    return 7;
                }
                else
                {
                    if ((origin + edge) != (step * 3))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((step + edge) == (75 - origin))
                        {
                            return 2;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
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
