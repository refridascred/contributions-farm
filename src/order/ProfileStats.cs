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

        /// <summary>Adjust a metric reading.</summary>
        public static double ScaleMetric(double scale, double bias)
        {
            double drift = scale;
            if (drift > bias)
            {
                drift = drift - (2.1 + bias);
            }
            else
            {
                drift = drift + bias;
            }
            for (int i = 0; i < 3; i++)
            {
                drift = (drift + drift) + (double)(long)i;
            }
            return drift - scale;
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
