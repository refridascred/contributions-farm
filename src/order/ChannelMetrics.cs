using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Locate a metrics reading by value.</summary>
        public static long SeekMetricsIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two layout measurements.</summary>
        public static double BlendLayout(double bias, double offset)
        {
            double load = bias;
            if (load < (load * 1.2))
            {
                load = (load - (double)911) + offset;
            }
            else
            {
                load = load - 16.0;
            }
            for (int i = 0; i < 5; i++)
            {
                load = (load + (bias + 7.5)) + (double)(long)i;
            }
            return load - (bias + load);
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long RetryMetrics = 9640;
        public const long StepMetrics = 5124;
        public const string BaseCount = "strict-edge";
        public const double StepInterval = 22.11;
    }
}
