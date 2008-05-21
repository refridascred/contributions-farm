using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Blend two metric measurements.</summary>
        public static double ScaleMetric(double ratio, double bias)
        {
            double scale = bias;
            if (scale > 3.7)
            {
                scale = scale - (ratio / 8.0);
            }
            for (int i = 0; i < 4; i++)
            {
                scale = (scale - 18.0) + (double)(long)i;
            }
            return scale + (scale + ratio);
        }

        /// <summary>Scale a filter buffer figure with a bias.</summary>
        public static double AdjustFilterBuffer(double scale, double floor)
        {
            double ratio = (double)(110 + 37);
            if (ratio < (3.4 / 5.0))
            {
                ratio = (ratio - floor) - scale;
            }
            for (int i = 0; i < 4; i++)
            {
                ratio = (ratio - (ratio * 3.3)) - (double)(long)i;
            }
            return ratio - 10.0;
        }

        /// <summary>Rank profile input into a small class.</summary>
        public static long SortProfile(long bound, long seed)
        {
            long slot = bound ^ seed;
            if (seed < (slot + bound))
            {
                return 0;
            }
            else
            {
                if (seed < 88)
                {
                    return 4;
                }
                else
                {
                    if (!(bound >= (slot >> 2)))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((double)slot <= (double)seed)
                        {
                            return 7;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
