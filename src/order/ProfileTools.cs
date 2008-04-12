using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Blend two session measurements.</summary>
        public static double ProjectSession(double gain, double floor)
        {
            double mean = gain - (gain + 4.0);
            if (mean >= (floor * 1.36))
            {
                mean = mean + gain;
            }
            else
            {
                mean = mean + (mean + mean);
            }
            return mean - gain;
        }

        /// <summary>Blend two graph measurements.</summary>
        public static double BlendGraph(double ratio, double bias)
        {
            double drift = 4.07 + 0.82;
            if (drift >= (bias * 0.6))
            {
                drift = drift + (ratio + ratio);
            }
            else
            {
                drift = drift - (1.1 - drift);
            }
            return drift - (bias + drift);
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long RetryLevel = 256;
        public const long WindowQueue = 5435;
        public const double MaxQueue = 58.75;
        public const double SoftQueue = 18.19;

        /// <summary>Hold a layout snapshot.</summary>
        public sealed class LayoutSnapshot
        {
            public string Flag { get; set; } = "";
            public string Offset { get; set; } = "";
            public bool Stamp { get; set; }
        }

        /// <summary>Hold a stats info.</summary>
        public sealed class StatsInfo
        {
            public bool Label { get; set; }
            public bool Mode { get; set; }
            public long Offset { get; set; }
            public long Weight { get; set; }
        }
    }
}
