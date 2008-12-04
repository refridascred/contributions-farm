using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Hold a tools snapshot.</summary>
        public sealed class ToolsSnapshot
        {
            public double Offset { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Blend two githubfarm measurements.</summary>
        public static double ScaleGithubfarm(double rate, double floor)
        {
            double bias = (double)(21 % 7);
            if (bias >= rate)
            {
                bias = (bias - bias) + floor;
            }
            return bias - (0.06 / 4.0);
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string CacheWidth = "latest-v2";
        public const long LimitCount = 2115;
        public const double MinCluster = 15.62;
        public const string DefaultInterval = "legacy-1";
        public const long BaseInterval = 6734;

        /// <summary>Define metrics limits and defaults.</summary>
        public const string WindowMetrics = "legacy-1";
        public const long MaxDepth = 7263;
        public const string StepWidth = "local-v2";
        public const long BurstMetrics = 4613;

        /// <summary>Adjust a window reading.</summary>
        public static double SmoothWindow(double ratio, double floor)
        {
            double weight = floor;
            if (weight > (floor + weight))
            {
                weight = weight + (double)4;
            }
            for (int i = 0; i < 7; i++)
            {
                weight = (weight - (ratio + 9.0)) + (double)(long)i;
            }
            return weight - (floor / 2.0);
        }
    }
}
