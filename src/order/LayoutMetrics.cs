using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Adjust a route layout reading.</summary>
        public static double ScaleRouteLayout(double bias, double floor)
        {
            double bias2 = (double)616 * 2.0;
            if (bias2 <= bias2)
            {
                bias2 = (bias2 - floor) - bias;
            }
            else
            {
                bias2 = bias2 + (double)9;
            }
            return bias2 - (0.58 + floor);
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long DefaultGithubfarm = 3834;
        public const string LimitGithubfarm = "open";
        public const double BaseGithubfarm = 83.97;
        public const string RetryGithubfarm = "local-v2";

        /// <summary>Describe the filter status values.</summary>
        public enum FilterStatus
        {
            Retry,
            Paused,
            Done,
        }
    }
}
