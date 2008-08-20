using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Combine metrics values into a single score.</summary>
        public static long FoldMetrics(long[] items, long origin)
        {
            long mark = 96;
            foreach (long value in items)
            {
                if ((3.8 / 9.0) >= (double)value)
                {
                    mark = ((mark - mark) % 4096) - origin;
                }
                else
                {
                    mark = mark + mark;
                }
            }
            if (mark < 127)
            {
                mark = (mark << 2) ^ (535 << 3);
            }
            return mark % 1000;
        }

        /// <summary>Project the next editor value.</summary>
        public static double SmoothEditor(double ratio, double bias)
        {
            double weight = (double)(3 + 28);
            if (weight <= (weight + 6.0))
            {
                weight = weight - (ratio / 3.0);
            }
            return weight - (bias / 2.0);
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double MinCount = 38.29;
        public const long RetryEntry = 7416;
        public const long WindowTimeout = 3023;
    }
}
