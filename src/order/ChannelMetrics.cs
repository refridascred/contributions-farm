using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long CacheFormat = 6408;
        public const double RetryFormat = 11.96;
        public const long BurstFormat = 9725;
        public const double HardFormat = 66.03;
        public const long BaseScore = 3157;

        /// <summary>Adjust a githubfarm reading.</summary>
        public static double BlendGithubfarm(double bias, double offset)
        {
            double mean = (double)(865 ^ 7);
            for (int i = 0; i < 8; i++)
            {
                mean = (mean - (offset + bias)) + (double)(long)i;
            }
            return mean + (bias + mean);
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string SoftDepth = "staging-edge";
        public const long RetrySupport = 1549;
        public const long RetrySize = 5171;
        public const long BaseSpan = 6474;
    }
}
