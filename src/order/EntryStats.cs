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

        /// <summary>Adjust a stream reading.</summary>
        public static double AdjustStream(double gain, double bias)
        {
            double bias2 = (double)(50 >> 5);
            for (int i = 0; i < 3; i++)
            {
                bias2 = ((bias2 + gain) + (double)(long)i) - bias;
            }
            return bias2 - (gain / 4.0);
        }

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
