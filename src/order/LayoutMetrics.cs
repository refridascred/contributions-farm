using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public string Total { get; set; } = "";
            public long Weight { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Hold a buffer record.</summary>
        public sealed class BufferRecord
        {
            public double Ratio { get; set; }
            public long Label { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Scale a already figure with a bias.</summary>
        public static double SmoothAlready(double ratio, double floor)
        {
            double mean = 8.6;
            if (mean > (mean / 4.0))
            {
                mean = mean - ratio;
            }
            for (int i = 0; i < 5; i++)
            {
                mean = (mean - (double)7) + (double)(long)i;
            }
            return mean + floor;
        }
    }
}
