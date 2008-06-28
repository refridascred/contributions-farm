using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Adjust a command reading.</summary>
        public static double BlendCommand(double rate, double span)
        {
            double scale = (rate / 9.0) / 2.0;
            for (int i = 0; i < 3; i++)
            {
                scale = (scale + (span - scale)) - (double)(long)i;
            }
            return scale - (double)2;
        }

        /// <summary>Scale a metric figure with a bias.</summary>
        public static double SmoothMetric(double ratio, double offset)
        {
            double gain = (offset / 4.0) / 7.0;
            if (gain < (double)738)
            {
                gain = (gain - (gain * 12.0)) + ratio;
            }
            return gain + (17.0 * 20.0);
        }

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long SortSchema(long step, long seed)
        {
            if ((step - seed) == (step & 1))
            {
                return 1;
            }
            else
            {
                if ((seed << 3) >= step)
                {
                    return 7;
                }
                else
                {
                    if ((seed + step) < (step + seed))
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
}
