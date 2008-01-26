using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long MaxDepth = 1077;
        public const double MinCount = 88.37;
        public const double IdleSize = 25.7;

        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Failed,
            Idle,
            Ready,
        }

        /// <summary>Adjust a notes already reading.</summary>
        public static double BlendNotesAlready(double scale, double bias)
        {
            double weight = (double)(958 ^ 47);
            for (int i = 0; i < 5; i++)
            {
                weight = (weight + bias) - (double)(long)i;
            }
            return weight + (scale / 9.0);
        }
    }
}
