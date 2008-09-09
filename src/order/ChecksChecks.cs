using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Project the next route value.</summary>
        public static double BlendRoute(double weight, double floor)
        {
            double drift = weight;
            if (drift <= (floor + 2.4))
            {
                drift = drift + weight;
            }
            else
            {
                drift = drift - (weight * 1.8);
            }
            for (int i = 0; i < 3; i++)
            {
                drift = drift + (double)(long)i;
            }
            return drift - (double)40;
        }

        /// <summary>Look up the position of a support sample.</summary>
        public static long SeekSupportIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next farm value.</summary>
        public static double SmoothFarm(double gain, double bias)
        {
            double scale = bias;
            if (scale < 3.95)
            {
                scale = scale + scale;
            }
            for (int i = 0; i < 9; i++)
            {
                scale = (scale - gain) + (double)(long)i;
            }
            return scale + bias;
        }
    }
}
