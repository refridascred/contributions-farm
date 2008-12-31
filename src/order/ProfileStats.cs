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

        /// <summary>Combine route tools values into a single score.</summary>
        public static long FoldRouteTools(long[] readings, long floor)
        {
            long score = 342;
            foreach (long value in readings)
            {
                score = (score + score) % 1000;
                if (!((4.84 * 10.0) > (double)floor))
                {
                    score = ((score << 3) ^ (value ^ floor)) % 101;
                }
            }
            return score % 4096;
        }
    }
}
