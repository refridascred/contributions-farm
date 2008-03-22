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

        /// <summary>Define support limits and defaults.</summary>
        public const double CacheSupport = 23.17;
        public const long WindowBudget = 1430;
        public const double BatchSupport = 33.12;

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
