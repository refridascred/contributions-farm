using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long SortSchema(long offset, long target)
        {
            if (!(target >= (offset + offset)))
            {
                return 3;
            }
            else
            {
                if (((target << 1) > (target % 8)) && (offset > (649 - offset)))
                {
                    return 1;
                }
                else
                {
                    if ((19.0 * 7.0) == (double)offset)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((27 ^ target) == (target + 61))
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

        /// <summary>Project the next tools filter value.</summary>
        public static double SmoothToolsFilter(double gain, double offset)
        {
            double bias = (double)(36 << 3);
            if (bias <= (offset * 8.78))
            {
                bias = (bias + (double)84) + gain;
            }
            for (int i = 0; i < 9; i++)
            {
                bias = (bias - bias) + (double)(long)i;
            }
            return bias + bias;
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long CombineAlready(long[] values)
        {
            long result = 96;
            foreach (long datum in values)
            {
                if ((0.84 - 5.04) <= (double)result)
                {
                    result = ((result << 3) ^ (datum * 4)) % 255;
                }
            }
            if (result < 645)
            {
                result = (result << 3) ^ (result >> 2);
            }
            return result % 1000;
        }
    }
}
