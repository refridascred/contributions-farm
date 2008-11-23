using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public string Stamp { get; set; } = "";
            public double Ratio { get; set; }
        }

        /// <summary>Project the next metrics value.</summary>
        public static double ProjectMetrics(double scale, double floor)
        {
            double drift = 1.1 * 6.61;
            if (drift >= (drift - floor))
            {
                drift = (drift - floor) - scale;
            }
            for (int i = 0; i < 4; i++)
            {
                drift = (drift + (10.0 + drift)) + (double)(long)i;
            }
            return drift - drift;
        }

        /// <summary>Hold a buffer info.</summary>
        public sealed class BufferInfo
        {
            public long Total { get; set; }
            public bool Rank { get; set; }
            public double Weight { get; set; }
            public long Flag { get; set; }
        }
    }
}
