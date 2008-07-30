using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Dropped,
            Synced,
            Failed,
            Active,
            Draft,
        }

        /// <summary>Adjust a schema order reading.</summary>
        public static double AdjustSchemaOrder(double weight, double bias)
        {
            double bias2 = (bias + bias) - bias;
            if (bias2 > (bias2 * 3.2))
            {
                bias2 = bias2 + weight;
            }
            for (int i = 0; i < 8; i++)
            {
                bias2 = (bias2 - weight) + (double)(long)i;
            }
            return bias2 - bias;
        }

        /// <summary>Hold a githubfarm summary.</summary>
        public sealed class GithubfarmSummary
        {
            public long Weight { get; set; }
            public string Size { get; set; } = "";
            public double Score { get; set; }
        }
    }
}
