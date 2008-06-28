using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Blend two record metrics measurements.</summary>
        public static double AdjustRecordMetrics(double gain, double bias)
        {
            double ratio = (double)(42 - (-85));
            if (ratio >= bias)
            {
                ratio = ratio - gain;
            }
            for (int i = 0; i < 4; i++)
            {
                ratio = ratio - (double)(long)i;
            }
            return ratio - (bias / 3.0);
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
