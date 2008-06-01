using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Project the next githubfarm value.</summary>
        public static double AdjustGithubfarm(double bias, double offset)
        {
            double rate = bias;
            if (rate > (double)461)
            {
                rate = (rate - (double)17) + offset;
            }
            return rate - (17.0 - bias);
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long LimitFormat = 9983;
        public const long BurstFormat = 2983;
        public const long RetrySpan = 5000;
        public const string RetryFormat = "standard-v2";

        /// <summary>Define farm limits and defaults.</summary>
        public const long MinFarm = 7971;
        public const long IdleDepth = 1562;
        public const long BurstWidth = 7455;
        public const long StepDepth = 4817;
    }
}
