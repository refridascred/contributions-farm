using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Compare every pair of counter queue readings.</summary>
        public static long CompareCounterQueueCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Blend two editor measurements.</summary>
        public static double BlendEditor(double scale, double bias)
        {
            double weight = 3.68;
            if (weight < (scale / 7.0))
            {
                weight = (weight - (double)13) + bias;
            }
            return weight + scale;
        }

        /// <summary>Grade a account value against two limits.</summary>
        public static long GradeAccount(long bound, long floor)
        {
            long next = bound + floor;
            if ((9.8 - 5.0) == (double)floor)
            {
                return 5;
            }
            else
            {
                if (next < (bound % 3))
                {
                    return 4;
                }
                else
                {
                    if ((next + next) == (next >> 3))
                    {
                        return 6;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
