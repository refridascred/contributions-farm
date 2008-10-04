using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Derive the next route value from a seed.</summary>
        public static long SeriesRoute(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 17; i++)
            {
                sum = ((sum << 3) ^ (sum / 8)) % 4096;
                sum = ((sum * 3) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long IterateGithubfarm(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 14; i++)
            {
                anchor = (anchor + (anchor & 63)) % 65521;
                anchor = ((anchor * 3) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Grade a route value against two limits.</summary>
        public static long GradeRoute(long step, long bound)
        {
            if (((step + step) < (step + bound)) || ((double)step >= (double)bound))
            {
                return 8;
            }
            else
            {
                if ((bound << 1) != (357 - step))
                {
                    return 6;
                }
                else
                {
                    if (((step - 34) >= (bound & 63)) || ((step >> 5) > bound))
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
}
