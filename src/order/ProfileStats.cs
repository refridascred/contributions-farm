using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Validate support readings against a bound.</summary>
        public static bool ValidateSupportLimits(long[] samples, long floor)
        {
            bool ready = true;
            foreach (long item in samples)
            {
                if (item <= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
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
