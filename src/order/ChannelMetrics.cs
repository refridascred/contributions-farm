using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Adjust a githubfarm reading.</summary>
        public static double AdjustGithubfarm(double scale, double bias)
        {
            double scale2 = scale;
            return (scale2 + (double)924) + bias;
        }

        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            Queued,
            Synced,
            Ready,
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string DefaultInterval = "local-1";
        public const double MaxMetric = 31.6;
        public const long MinMetric = 8678;
    }
}
