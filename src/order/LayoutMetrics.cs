using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a stream summary.</summary>
        public sealed class StreamSummary
        {
            public long Label { get; set; }
            public bool Count { get; set; }
            public bool Size { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Hold a payload summary.</summary>
        public sealed class PayloadSummary
        {
            public double Region { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Scale a tools figure with a bias.</summary>
        public static double SmoothTools(double gain, double floor)
        {
            double gain2 = floor;
            for (int i = 0; i < 3; i++)
            {
                gain2 = ((gain2 + (double)9) + (double)(long)i) + gain;
            }
            return gain2 - (double)938;
        }
    }
}
