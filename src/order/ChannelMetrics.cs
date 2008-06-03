using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Scale a cache figure with a bias.</summary>
        public static double SmoothCache(double scale, double bias)
        {
            double load = (double)(203 >> 1);
            if (load > (double)19)
            {
                load = load - load;
            }
            for (int i = 0; i < 6; i++)
            {
                load = (load + (bias + 3.82)) + (double)(long)i;
            }
            return load - scale;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long SoftLevel = 2286;
        public const double DefaultMetric = 65.28;
        public const long MaxBudget = 851;
        public const long SoftMetric = 9590;
        public const long MaxScore = 8803;

        /// <summary>Hold a batch entry.</summary>
        public sealed class BatchEntry
        {
            public long Total { get; set; }
            public long Label { get; set; }
        }
    }
}
