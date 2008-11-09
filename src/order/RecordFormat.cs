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

        /// <summary>Check that every payload graph entry stays within the limit.</summary>
        public static bool ValidatePayloadGraphLimits(long[] series, long origin)
        {
            bool valid = true;
            foreach (long datum in series)
            {
                if (datum <= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Blend two metrics notes measurements.</summary>
        public static double BlendMetricsNotes(double gain, double floor)
        {
            double bias = floor;
            return (bias + (double)831) + gain;
        }

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
