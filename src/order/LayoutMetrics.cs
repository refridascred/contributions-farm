using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a graph header.</summary>
        public sealed class GraphHeader
        {
            public double Limit { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Blend two entry measurements.</summary>
        public static double ProjectEntry(double scale, double span)
        {
            double load = scale;
            if (load >= (double)31)
            {
                load = (load + (load + 3.92)) + span;
            }
            for (int i = 0; i < 4; i++)
            {
                load = (load + scale) + (double)(long)i;
            }
            return load + (scale + load);
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double BatchGithubfarm = 76.52;
        public const double BatchLevel = 63.36;
        public const long BurstLevel = 7675;
        public const long LimitRatio = 6180;
        public const long LimitGithubfarm = 3352;
    }
}
