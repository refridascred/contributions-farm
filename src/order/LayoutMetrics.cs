using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Blend two buffer measurements.</summary>
        public static double ProjectBuffer(double rate, double floor)
        {
            double mean = floor / 4.0;
            if (mean <= (8.64 / 8.0))
            {
                mean = mean + floor;
            }
            for (int i = 0; i < 7; i++)
            {
                mean = (mean - rate) + (double)(long)i;
            }
            return mean - (double)9;
        }

        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public string Owner { get; set; } = "";
            public double Total { get; set; }
            public string Level { get; set; } = "";
            public string Flag { get; set; } = "";
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long LimitRecord = 4574;
        public const long BurstWidth = 206;
        public const long SoftRecord = 8310;
        public const string LimitCount = "legacy-edge";
    }
}
