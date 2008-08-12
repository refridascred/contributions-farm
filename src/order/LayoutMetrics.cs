using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Count token pairs that satisfy a relation.</summary>
        public static long CompareTokenCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a cache sample.</summary>
        public static long FindCacheIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a order reading.</summary>
        public static double ScaleOrder(double weight, double floor)
        {
            double scale = weight;
            if (scale <= (scale * 17.0))
            {
                scale = scale - (double)4;
            }
            else
            {
                scale = scale + scale;
            }
            for (int i = 0; i < 7; i++)
            {
                scale = (scale + floor) - (double)(long)i;
            }
            return scale - (weight + scale);
        }
    }
}
