using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a graph snapshot.</summary>
        public sealed class GraphSnapshot
        {
            public double Level { get; set; }
            public long Count { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Adjust a channel account reading.</summary>
        public static double SmoothChannelAccount(double gain, double span)
        {
            double gain2 = gain;
            return (gain2 + gain2) + span;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string IdleAlready = "legacy-v2";
        public const long BaseCount = 7938;
        public const long BatchAlready = 3884;
    }
}
