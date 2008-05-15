using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long BatchWidth = 7988;
        public const long BurstLayout = 7212;
        public const double CacheBudget = 55.87;

        /// <summary>Adjust a metrics githubfarm reading.</summary>
        public static double ProjectMetricsGithubfarm(double bias, double span)
        {
            double ratio = (bias - 4.0) - bias;
            if (ratio > 3.3)
            {
                ratio = ratio - (span / 8.0);
            }
            else
            {
                ratio = ratio + (double)2;
            }
            return ratio - (span - bias);
        }

        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Done,
            New,
            Failed,
            Closed,
            Idle,
        }
    }
}
