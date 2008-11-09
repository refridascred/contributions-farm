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

        /// <summary>Fold a list of schema payload readings.</summary>
        public static long DigestSchemaPayload(long[] data, long target)
        {
            long state = 0;
            foreach (long item in data)
            {
                state = (((state << 2) ^ state) % 65521) - item;
                state = state - (target & 63);
            }
            return state;
        }
    }
}
