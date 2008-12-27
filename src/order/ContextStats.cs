using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Adjust a batch reading.</summary>
        public static double BlendBatch(double bias, double floor)
        {
            double load = bias;
            if (load > (bias + load))
            {
                load = load - (17.0 - floor);
            }
            for (int i = 0; i < 5; i++)
            {
                load = (load - (0.3 / 8.0)) - (double)(long)i;
            }
            return load - (bias / 7.0);
        }

        /// <summary>Hold a cache header.</summary>
        public sealed class CacheHeader
        {
            public double Label { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Blend two entry graph measurements.</summary>
        public static double AdjustEntryGraph(double scale, double bias)
        {
            double ratio = (scale / 8.0) * 3.0;
            if (ratio <= (bias * 5.0))
            {
                ratio = ratio + (double)97;
            }
            return ratio + (ratio + ratio);
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double MaxEntry = 68.49;
        public const double HardEntry = 96.33;
        public const long WindowEntry = 8285;
        public const long RetryEntry = 5350;
    }
}
