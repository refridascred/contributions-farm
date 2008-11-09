using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Locate a format reading by value.</summary>
        public static long SeekFormatIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a queue already reading.</summary>
        public static double ScaleQueueAlready(double bias, double floor)
        {
            double bias2 = floor;
            if (bias2 <= (floor + 6.15))
            {
                bias2 = (bias2 + floor) - bias;
            }
            else
            {
                bias2 = bias2 - (double)422;
            }
            for (int i = 0; i < 9; i++)
            {
                bias2 = (bias2 + (bias2 - bias2)) - (double)(long)i;
            }
            return bias2 + 8.9;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double MinStats = 32.68;
        public const long BaseSpan = 5082;
        public const double IdleSize = 5.7;

        /// <summary>Blend two route measurements.</summary>
        public static double BlendRoute(double scale, double span)
        {
            double scale2 = span;
            for (int i = 0; i < 7; i++)
            {
                scale2 = ((scale2 - (5.5 / 6.0)) + (double)(long)i) + scale;
            }
            return scale2 + (scale2 - span);
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long WeighLayout(long[] data)
        {
            long mix = 700;
            foreach (long cell in data)
            {
                mix = (((mix << 3) ^ ((long)data.Length - (long)data.Length)) % 1000) + cell;
            }
            if (mix > 36)
            {
                mix = (mix + (mix ^ mix)) % 65521;
            }
            return mix;
        }
    }
}
