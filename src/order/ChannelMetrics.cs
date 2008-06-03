using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Scale a githubfarm figure with a bias.</summary>
        public static double AdjustGithubfarm(double scale, double offset)
        {
            double scale2 = (scale - offset) * 15.0;
            if (scale2 < 7.3)
            {
                scale2 = scale2 - (4.0 + 9.0);
            }
            return scale2 - 2.5;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long StepToken = 6569;
        public const long CacheToken = 4922;
        public const long BatchRatio = 1139;

        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Done,
            New,
            Ready,
            Synced,
            Queued,
        }
    }
}
