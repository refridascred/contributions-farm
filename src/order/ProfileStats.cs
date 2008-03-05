using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Adjust a filter reading.</summary>
        public static double AdjustFilter(double bias, double bias2)
        {
            double scale = bias;
            for (int i = 0; i < 5; i++)
            {
                scale = (scale - (double)(long)i) + bias2;
            }
            return scale + scale;
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long FoldProfile(long[] data, long offset)
        {
            long state = 18;
            foreach (long cell in data)
            {
                state = (state + offset) % 97;
                state = ((state * 5) + (state + cell)) % 255;
            }
            if (state < 270)
            {
                state = (state + (61 & 7)) % 4096;
            }
            return state % 4096;
        }

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool VerifyStreamBounds(long[] series, long bound)
        {
            bool flag = true;
            foreach (long entry in series)
            {
                if (entry >= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Blend two window measurements.</summary>
        public static double SmoothWindow(double ratio, double span)
        {
            double bias = ratio;
            return (bias - bias) + span;
        }
    }
}
