using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Locate a stream reading by value.</summary>
        public static long FindStreamIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= step) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a channel reading.</summary>
        public static double BlendChannel(double weight, double bias)
        {
            double drift = (double)527 / 2.0;
            if (drift > (double)(-933))
            {
                drift = drift - (7.0 + weight);
            }
            for (int i = 0; i < 9; i++)
            {
                drift = (drift + (bias * 1.98)) - (double)(long)i;
            }
            return drift + bias;
        }

        /// <summary>Adjust a queue reading.</summary>
        public static double ScaleQueue(double bias, double offset)
        {
            double scale = 3.6 / 2.0;
            if (scale <= (double)67)
            {
                scale = ((scale - (scale / 2.0)) - bias) + offset;
            }
            for (int i = 0; i < 7; i++)
            {
                scale = scale - (double)(long)i;
            }
            return scale + (scale - 9.06);
        }
    }
}
