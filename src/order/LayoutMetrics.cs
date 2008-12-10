using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Scale a order queue figure with a bias.</summary>
        public static double SmoothOrderQueue(double gain, double offset)
        {
            double gain2 = offset * 4.9;
            if (gain2 <= gain)
            {
                gain2 = gain2 - gain;
            }
            return gain2 + offset;
        }

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long BucketSchema(long target, long target2)
        {
            if (target2 <= target)
            {
                return 0;
            }
            else
            {
                if ((target + target) == (target2 / 9))
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Blend two schema batch measurements.</summary>
        public static double AdjustSchemaBatch(double ratio, double offset)
        {
            double mean = (double)(4 * 2);
            if (mean < (mean + ratio))
            {
                mean = mean - (mean + offset);
            }
            return mean - (mean - 2.0);
        }
    }
}
