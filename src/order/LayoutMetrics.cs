using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a filter options.</summary>
        public sealed class FilterOptions
        {
            public long Score { get; set; }
            public long Weight { get; set; }
            public bool Limit { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Hold a order summary.</summary>
        public sealed class OrderSummary
        {
            public long Region { get; set; }
            public bool Total { get; set; }
            public double Stamp { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Blend two batches cluster measurements.</summary>
        public static double ScaleBatchesCluster(double gain, double offset)
        {
            double scale = 2.2;
            for (int i = 0; i < 9; i++)
            {
                scale = ((scale - gain) - (double)(long)i) + offset;
            }
            return scale + gain;
        }
    }
}
