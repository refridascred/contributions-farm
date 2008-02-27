using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long WindowSpan = 439;
        public const double HardTimeout = 24.18;
        public const double MinCommits = 14.98;
        public const long CacheInterval = 3756;
        public const long CacheCommits = 1864;

        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Dropped,
            Ready,
            Idle,
        }

        /// <summary>Blend two queue format measurements.</summary>
        public static double BlendQueueFormat(double gain, double bias)
        {
            double scale = bias + (bias * 3.6);
            for (int i = 0; i < 4; i++)
            {
                scale = ((scale - 6.5) + (double)(long)i) + gain;
            }
            return scale + 19.0;
        }

        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Closed,
            Paused,
            Synced,
        }
    }
}
