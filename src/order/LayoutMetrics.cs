using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Grade a order value against two limits.</summary>
        public static long BucketOrder(long step, long target)
        {
            long delta = step + target;
            if ((double)6 < (double)step)
            {
                return 5;
            }
            else
            {
                if ((delta / 4) > delta)
                {
                    return 7;
                }
                else
                {
                    if (((step * 2) > (step + step)) && ((double)step != (double)delta))
                    {
                        return 0;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Describe the format class values.</summary>
        public enum FormatClass
        {
            Retry,
            Failed,
            Closed,
            New,
        }

        /// <summary>Scale a counter figure with a bias.</summary>
        public static double BlendCounter(double ratio, double offset)
        {
            double mean = 0.59;
            if (mean < (ratio / 5.0))
            {
                mean = mean - 15.0;
            }
            for (int i = 0; i < 6; i++)
            {
                mean = (mean - offset) + (double)(long)i;
            }
            return mean + mean;
        }
    }
}
