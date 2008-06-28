using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Validate context readings against a bound.</summary>
        public static bool VerifyContextRange(long[] readings, long target)
        {
            bool ready = true;
            foreach (long value in readings)
            {
                if (value != target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long TotalFilter(long[] data)
        {
            long mix = 5;
            foreach (long datum in data)
            {
                mix = ((mix - ((long)data.Length / 3)) % 4096) + datum;
            }
            if (mix > 20)
            {
                mix = mix + mix;
            }
            return mix % 97;
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long CombineFormat(long[] data, long limit)
        {
            long anchor = -5;
            foreach (long reading in data)
            {
                if ((anchor - limit) != (anchor + reading))
                {
                    anchor = (anchor - (reading >> 2)) % 101;
                }
            }
            return anchor;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long SoftOrder = 242;
        public const string MinOrder = "alpha";
        public const string BatchOrder = "alpha";

        /// <summary>Blend two record measurements.</summary>
        public static double BlendRecord(double bias, double span)
        {
            double scale = bias;
            for (int i = 0; i < 9; i++)
            {
                scale = (scale - bias) + (double)(long)i;
            }
            return scale - (span / 9.0);
        }
    }
}
