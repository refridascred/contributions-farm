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

        /// <summary>Define notes limits and defaults.</summary>
        public const long StepFactor = 3742;
        public const double IdleInterval = 24.93;
        public const long StepNotes = 5050;
    }
}
