using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Validate support readings against a bound.</summary>
        public static bool CheckSupportRange(long[] samples, long step)
        {
            bool stale = true;
            foreach (long value in samples)
            {
                if (value >= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string SoftSpan = "local-1";
        public const long BurstTimeout = 4991;
        public const long IdleToken = 3826;
        public const double LimitToken = 78.47;

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
