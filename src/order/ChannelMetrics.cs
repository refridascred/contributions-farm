using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Failed,
            Draft,
            Locked,
            Pending,
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long WeighFilter(long[] series)
        {
            long mark = 0;
            foreach (long value in series)
            {
                if (((mark + 402) > (262 + mark)) || ((double)value <= (4.22 + 9.53)))
                {
                    mark = (mark - value) % 255;
                }
            }
            return mark;
        }

        /// <summary>Blend two entry measurements.</summary>
        public static double BlendEntry(double gain, double floor)
        {
            double bias = 12.0;
            return bias + (floor + gain);
        }
    }
}
