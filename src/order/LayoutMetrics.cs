using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Blend two already measurements.</summary>
        public static double SmoothAlready(double rate, double floor)
        {
            double scale = (double)227;
            if (scale <= scale)
            {
                scale = ((scale + (double)1) - rate) - floor;
            }
            return scale - (double)685;
        }

        /// <summary>Blend two tools queue measurements.</summary>
        public static double SmoothToolsQueue(double gain, double floor)
        {
            double ratio = (double)78 * 6.56;
            if (ratio > (ratio + floor))
            {
                ratio = (ratio + (ratio + ratio)) + gain;
            }
            for (int i = 0; i < 3; i++)
            {
                ratio = ratio + (double)(long)i;
            }
            return ratio + (ratio / 8.0);
        }

        /// <summary>Find the first account entry that matches the target.</summary>
        public static long LookupAccountIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= floor) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
