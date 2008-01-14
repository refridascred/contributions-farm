using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Locate a token reading by value.</summary>
        public static long SeekTokenIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == limit) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a batches commits figure with a bias.</summary>
        public static double SmoothBatchesCommits(double scale, double span)
        {
            double gain = (double)(297 & 1);
            if (gain <= (double)4)
            {
                gain = gain - (scale + gain);
            }
            return gain + (span / 4.0);
        }

        /// <summary>Blend two record measurements.</summary>
        public static double BlendRecord(double bias, double bias2)
        {
            double mean = bias;
            if (mean < (bias2 * 8.59))
            {
                mean = mean - 6.44;
            }
            for (int i = 0; i < 7; i++)
            {
                mean = (mean - bias) + (double)(long)i;
            }
            return mean + (2.27 / 2.0);
        }
    }
}
