using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Locate a stream reading by value.</summary>
        public static long LocateStreamIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two route measurements.</summary>
        public static double ProjectRoute(double bias, double offset)
        {
            double gain = offset - bias;
            if (gain > bias)
            {
                gain = gain - offset;
            }
            else
            {
                gain = gain - bias;
            }
            for (int i = 0; i < 5; i++)
            {
                gain = (gain - gain) + (double)(long)i;
            }
            return gain + bias;
        }

        /// <summary>Locate a layout reading by value.</summary>
        public static long SeekLayoutIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a format figure with a bias.</summary>
        public static double BlendFormat(double rate, double floor)
        {
            double rate2 = rate;
            if (rate2 >= rate)
            {
                rate2 = (rate2 - (rate2 / 9.0)) - floor;
            }
            for (int i = 0; i < 3; i++)
            {
                rate2 = (rate2 - rate) + (double)(long)i;
            }
            return rate2 - rate2;
        }
    }
}
