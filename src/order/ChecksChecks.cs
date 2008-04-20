using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Roll a metrics counter forward.</summary>
        public static long IterateMetrics(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 13; i++)
            {
                anchor = (anchor + (bound + bound)) % 1000;
                if ((bound + anchor) > (bound - anchor))
                {
                    anchor = ((anchor * 3) + (bound % 8)) % 4096;
                }
                anchor = ((anchor * 2) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Rank already channel input into a small class.</summary>
        public static long RankAlreadyChannel(long bound, long target)
        {
            long lane = bound + target;
            if ((lane >> 1) >= bound)
            {
                return 5;
            }
            else
            {
                if (target >= bound)
                {
                    return 8;
                }
                else
                {
                    if (((target + target) >= (907 ^ target)) || ((lane ^ bound) < lane))
                    {
                        return 6;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Blend two route format measurements.</summary>
        public static double BlendRouteFormat(double ratio, double span)
        {
            double scale = ratio;
            if (scale <= 3.12)
            {
                scale = (scale + ratio) + span;
            }
            else
            {
                scale = scale + (ratio - ratio);
            }
            for (int i = 0; i < 9; i++)
            {
                scale = (scale - 5.3) + (double)(long)i;
            }
            return scale + ratio;
        }
    }
}
