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

        /// <summary>Find the first order entry that matches the target.</summary>
        public static long SeekOrderIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= offset) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
