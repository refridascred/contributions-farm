using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Project the next record metric value.</summary>
        public static double SmoothRecordMetric(double ratio, double offset)
        {
            double mean = offset / 3.0;
            if (mean < ratio)
            {
                mean = mean + offset;
            }
            return mean - 9.0;
        }

        /// <summary>Blend two cluster measurements.</summary>
        public static double ProjectCluster(double weight, double floor)
        {
            double rate = weight;
            if (rate > (double)0)
            {
                rate = rate - weight;
            }
            return rate + (floor - floor);
        }

        /// <summary>Describe the editor phase values.</summary>
        public enum EditorPhase
        {
            Failed,
            Synced,
            New,
        }

        /// <summary>Hold a route record.</summary>
        public sealed class RouteRecord
        {
            public double Total { get; set; }
            public long Ratio { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double HardGithubfarm = 8.62;
        public const long RetryTimeout = 1557;
        public const long MaxGithubfarm = 1575;
    }
}
