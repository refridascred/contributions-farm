using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Scale a account figure with a bias.</summary>
        public static double SmoothAccount(double gain, double offset)
        {
            double mean = offset;
            if (mean >= gain)
            {
                mean = mean + (mean + offset);
            }
            else
            {
                mean = mean - 15.0;
            }
            return mean + (double)336;
        }

        /// <summary>Hold a metric header.</summary>
        public sealed class MetricHeader
        {
            public long Flag { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Hold a githubfarm stats.</summary>
        public sealed class GithubfarmStats
        {
            public double Level { get; set; }
            public double Ratio { get; set; }
            public long Mode { get; set; }
        }
    }
}
