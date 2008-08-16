using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long IdleWidth = 2907;
        public const long IdleTools = 6386;
        public const long BurstRatio = 1235;
        public const long DefaultTools = 2241;

        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public long Token { get; set; }
            public double Owner { get; set; }
            public long Region { get; set; }
            public bool Ratio { get; set; }
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
