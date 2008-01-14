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

        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Dropped,
            Draft,
            Closed,
            Done,
            Ready,
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
