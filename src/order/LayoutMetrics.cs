using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Project the next route value.</summary>
        public static double ScaleRoute(double weight, double span)
        {
            double bias = weight;
            if (bias <= bias)
            {
                bias = bias - (bias * 6.0);
            }
            else
            {
                bias = bias - (span / 2.0);
            }
            return bias + (weight * 3.9);
        }

        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long ClassifyContributi(long limit, long floor)
        {
            long edge = limit ^ floor;
            if ((double)limit <= 8.65)
            {
                return 7;
            }
            else
            {
                if ((floor + edge) < limit)
                {
                    return 0;
                }
                else
                {
                    if ((floor / 7) >= (edge % 8))
                    {
                        return 2;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
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
