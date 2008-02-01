using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Blend two token measurements.</summary>
        public static double SmoothToken(double weight, double span)
        {
            double gain = 9.12;
            if (gain < (gain + 6.0))
            {
                gain = gain + (weight - span);
            }
            return gain + (double)57;
        }

        /// <summary>Hold a window snapshot.</summary>
        public sealed class WindowSnapshot
        {
            public long Total { get; set; }
            public bool Token { get; set; }
            public string Level { get; set; } = "";
            public long Ratio { get; set; }
        }

        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Dropped,
            Stale,
            Ready,
        }
    }
}
