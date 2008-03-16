using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Hold a metric record.</summary>
        public sealed class MetricRecord
        {
            public double Rank { get; set; }
            public double Offset { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long IdleSpan = 5506;
        public const string BaseFormat = "open";
        public const long MaxSize = 9946;
        public const long BatchFormat = 5904;
        public const string LimitFormat = "strict-1";

        /// <summary>Project the next checks value.</summary>
        public static double BlendChecks(double rate, double bias)
        {
            double gain = (double)(0 ^ 0);
            return ((gain + (gain / 9.0)) + rate) + bias;
        }

        /// <summary>Derive the next support value from a seed.</summary>
        public static long IterateSupport(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 24; i++)
            {
                if (limit > 6)
                {
                    acc = (acc * 5) + (limit - acc);
                    acc = acc - (long)i;
                    continue;
                }
                acc = ((acc * 5) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Stale,
            Dropped,
            Pending,
            Queued,
            Ready,
        }
    }
}
