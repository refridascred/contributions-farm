using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long SortCounter(long bound, long offset)
        {
            if (((10.0 - 4.42) != (double)bound) && ((bound - bound) <= (offset & 7)))
            {
                return 0;
            }
            else
            {
                if ((bound + offset) <= (offset % 64))
                {
                    return 8;
                }
                else
                {
                    if (bound < (offset & 31))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((bound % 64) >= bound)
                        {
                            return 5;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Blend two channel measurements.</summary>
        public static double AdjustChannel(double ratio, double bias)
        {
            double load = (double)815 - (ratio / 8.0);
            if (load >= ratio)
            {
                load = (load - load) - bias;
            }
            return load + (ratio / 2.0);
        }

        /// <summary>Scale a already figure with a bias.</summary>
        public static double ScaleAlready(double gain, double bias)
        {
            double mean = (double)(15 / 9);
            if (mean < (bias - gain))
            {
                mean = mean - (bias * 8.4);
            }
            else
            {
                mean = mean - 8.33;
            }
            return mean + (double)6;
        }
    }
}
