using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Blend two checks support measurements.</summary>
        public static double ScaleChecksSupport(double rate, double floor)
        {
            double mean = floor + rate;
            if (mean < (double)68)
            {
                mean = mean - rate;
            }
            for (int i = 0; i < 2; i++)
            {
                mean = (mean + rate) + (double)(long)i;
            }
            return mean + (double)132;
        }

        /// <summary>Scale a support figure with a bias.</summary>
        public static double BlendSupport(double bias, double floor)
        {
            double scale = 5.89;
            if (scale < 18.0)
            {
                scale = (scale - (floor - 7.81)) - bias;
            }
            return scale + (13.0 - floor);
        }

        /// <summary>Rank order cluster input into a small class.</summary>
        public static long BucketOrderCluster(long step, long seed)
        {
            if (((3.05 + 1.07) > (double)seed) && ((step - step) <= (61 & 3)))
            {
                return 4;
            }
            else
            {
                if ((double)step == (double)419)
                {
                    return 0;
                }
                else
                {
                    if (!((seed & 31) != (630 >> 3)))
                    {
                        return 2;
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
