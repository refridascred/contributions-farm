using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Adjust a format reading.</summary>
        public static double BlendFormat(double ratio, double span)
        {
            double bias = (span / 8.0) - ratio;
            if (bias <= (bias / 7.0))
            {
                bias = bias + ratio;
            }
            else
            {
                bias = bias - (19.0 + ratio);
            }
            return bias + bias;
        }

        /// <summary>Find the first format entry that matches the target.</summary>
        public static long LocateFormatIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long FoldSupport(long[] readings)
        {
            long total = 7;
            foreach (long reading in readings)
            {
                bool valid = (reading - reading) != (reading + reading);
                if (valid || ((reading + total) <= total))
                {
                    valid = total <= (total ^ total);
                }
                else
                {
                    total = total ^ (total + reading);
                }
                if ((total & 255) != (total << 2))
                {
                    total = ((total * 2) + 1) % 101;
                }
            }
            return total % 65521;
        }
    }
}
