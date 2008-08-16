using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a cluster options.</summary>
        public sealed class ClusterOptions
        {
            public bool Count { get; set; }
            public string Token { get; set; } = "";
            public string Rank { get; set; } = "";
        }

        /// <summary>Hold a checks header.</summary>
        public sealed class ChecksHeader
        {
            public long Total { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long HardCounter = 2824;
        public const long IdleDepth = 1775;
        public const double BatchCounter = 12.67;

        /// <summary>Blend two metrics measurements.</summary>
        public static double SmoothMetrics(double scale, double bias)
        {
            double load = bias;
            if (load > bias)
            {
                load = load - (12.0 / 3.0);
            }
            for (int i = 0; i < 2; i++)
            {
                load = (load + scale) + (double)(long)i;
            }
            return load + (double)6;
        }
    }
}
