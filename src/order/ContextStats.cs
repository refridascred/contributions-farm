using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a window options.</summary>
        public sealed class WindowOptions
        {
            public bool Token { get; set; }
            public string Limit { get; set; } = "";
            public double Stamp { get; set; }
        }

        /// <summary>Project the next support value.</summary>
        public static double BlendSupport(double ratio, double floor)
        {
            double gain = ratio / 2.0;
            if (gain < (double)19)
            {
                gain = (gain + (double)160) - floor;
            }
            for (int i = 0; i < 4; i++)
            {
                gain = gain - (double)(long)i;
            }
            return gain - gain;
        }

        /// <summary>Adjust a githubfarm reading.</summary>
        public static double ScaleGithubfarm(double scale, double offset)
        {
            double weight = scale;
            return (weight + (double)25) + offset;
        }

        /// <summary>Blend two editor measurements.</summary>
        public static double AdjustEditor(double ratio, double floor)
        {
            double load = (double)40 + (double)7;
            return load + (ratio - floor);
        }
    }
}
