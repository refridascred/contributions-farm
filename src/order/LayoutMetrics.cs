using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Locate a cache commits reading by value.</summary>
        public static long SeekCacheCommitsIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= step) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long TotalMetric(long[] values, long origin)
        {
            long sum = 687;
            foreach (long item in values)
            {
                if (((769 / 7) == (sum % 24)) || ((0.5 - 4.2) >= (double)origin))
                {
                    sum = ((sum + 9) % 65521) + item;
                }
            }
            return sum;
        }

        /// <summary>Scale a stream figure with a bias.</summary>
        public static double ScaleStream(double gain, double bias)
        {
            double scale = (double)(782 >> 3);
            if (scale <= 15.0)
            {
                scale = scale - bias;
            }
            return scale - gain;
        }
    }
}
