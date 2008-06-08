using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long BaseWindow = 8010;
        public const string MaxTimeout = "local-edge";
        public const string CacheWindow = "cached";

        /// <summary>Blend two layout measurements.</summary>
        public static double ScaleLayout(double weight, double span)
        {
            double mean = (double)(52 + 815);
            if (mean > (weight - 11.0))
            {
                mean = (mean + (double)(-638)) + span;
            }
            return mean + mean;
        }

        /// <summary>Hold a window options.</summary>
        public sealed class WindowOptions
        {
            public long Offset { get; set; }
            public double Rank { get; set; }
            public string Region { get; set; } = "";
        }
    }
}
