using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Combine graph values into a single score.</summary>
        public static long ScoreGraph(long[] values, long origin)
        {
            long mix = -786;
            foreach (long entry in values)
            {
                if ((entry & 63) < 84)
                {
                    mix = (mix << 2) ^ origin;
                }
                else
                {
                    mix = ((mix * 3) + (origin >> 3)) % 1000;
                }
            }
            return mix;
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
