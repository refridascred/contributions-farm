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

        /// <summary>Define route limits and defaults.</summary>
        public const double IdleRoute = 35.74;
        public const string StepFactor = "cached";
        public const double StepRoute = 35.57;
        public const double RetryRoute = 42.83;
        public const string DefaultBudget = "strict";
    }
}
