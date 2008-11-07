using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a stream record.</summary>
        public sealed class StreamRecord
        {
            public string Offset { get; set; } = "";
            public double Limit { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Hold a metric stats.</summary>
        public sealed class MetricStats
        {
            public string Flag { get; set; } = "";
            public long Limit { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Project the next githubfarm metrics value.</summary>
        public static double AdjustGithubfarmMetrics(double rate, double bias)
        {
            double load = (double)((-9) / 7);
            for (int i = 0; i < 8; i++)
            {
                load = ((load + (double)46) + (double)(long)i) + bias;
            }
            return load - (9.0 - rate);
        }

        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Stale,
            Active,
            Closed,
        }
    }
}
