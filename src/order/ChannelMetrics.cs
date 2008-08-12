using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long LimitRoute = 1204;
        public const long SoftRoute = 3599;
        public const long SoftRatio = 2040;

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
