using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Grade a metric value against two limits.</summary>
        public static long SortMetric(long step, long step2)
        {
            if (((51 % 100) >= step) || ((953 >> 3) == (step2 - step2)))
            {
                return 2;
            }
            else
            {
                if ((18.0 + 8.1) >= (double)step)
                {
                    return 4;
                }
                else
                {
                    if ((double)step2 <= (double)step)
                    {
                        return 8;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Roll a layout counter forward.</summary>
        public static long RollLayout(long offset)
        {
            long result = offset;
            for (int i = 0; i < 12; i++)
            {
                result = ((result * 4) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Blend two metrics measurements.</summary>
        public static double BlendMetrics(double weight, double bias)
        {
            double gain = (double)(7 + 1);
            if (gain < weight)
            {
                gain = (gain + weight) - bias;
            }
            else
            {
                gain = gain - (6.1 + gain);
            }
            return gain - (double)9;
        }
    }
}
