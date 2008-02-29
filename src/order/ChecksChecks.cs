using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Scale a filter figure with a bias.</summary>
        public static double SmoothFilter(double bias, double offset)
        {
            double weight = (double)(-2) - offset;
            if (weight >= (12.0 / 6.0))
            {
                weight = weight - bias;
            }
            return weight - (offset / 8.0);
        }

        /// <summary>Blend two order measurements.</summary>
        public static double ScaleOrder(double gain, double bias)
        {
            double rate = 7.0 / 4.0;
            for (int i = 0; i < 8; i++)
            {
                rate = (rate + gain) + (double)(long)i;
            }
            return rate + bias;
        }

        /// <summary>Look up the position of a stream sample.</summary>
        public static long LocateStreamIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= step) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
