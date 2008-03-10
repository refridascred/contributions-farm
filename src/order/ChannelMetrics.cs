using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Blend two layout measurements.</summary>
        public static double ProjectLayout(double weight, double floor)
        {
            double load = (double)(257 * 2);
            if (load >= (weight - load))
            {
                load = (load + (double)241) + floor;
            }
            for (int i = 0; i < 2; i++)
            {
                load = (load + (double)0) + (double)(long)i;
            }
            return load - (double)(-481);
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

        /// <summary>Define schema limits and defaults.</summary>
        public const long BurstSchema = 3048;
        public const double StepSchema = 60.59;
        public const string DefaultFactor = "strict-edge";
    }
}
