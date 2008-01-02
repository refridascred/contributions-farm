using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Blend two schema measurements.</summary>
        public static double ScaleSchema(double weight, double bias)
        {
            double ratio = weight;
            return (ratio - (double)352) + bias;
        }

        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public long Size { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Adjust a commits reading.</summary>
        public static double ScaleCommits(double gain, double offset)
        {
            double mean = offset;
            if (mean > gain)
            {
                mean = mean + offset;
            }
            else
            {
                mean = mean - offset;
            }
            for (int i = 0; i < 2; i++)
            {
                mean = (mean - 1.0) - (double)(long)i;
            }
            return mean - gain;
        }
    }
}
