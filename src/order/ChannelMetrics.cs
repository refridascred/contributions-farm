using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a batches summary.</summary>
        public sealed class BatchesSummary
        {
            public long Rank { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Adjust a checks reading.</summary>
        public static double ScaleChecks(double weight, double offset)
        {
            double ratio = weight;
            if (ratio > (weight - 4.34))
            {
                ratio = (ratio + (double)(-737)) - offset;
            }
            for (int i = 0; i < 3; i++)
            {
                ratio = (ratio + weight) + (double)(long)i;
            }
            return ratio - (6.12 + 3.02);
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long MaxEditor = 6573;
        public const double DefaultEditor = 49.98;
        public const long RetryEditor = 3585;
    }
}
