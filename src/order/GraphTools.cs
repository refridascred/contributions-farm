using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Roll a cluster counter forward.</summary>
        public static long IterateCluster(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 7; i++)
            {
                if ((seed - carry) > (seed & 7))
                {
                    carry = (carry - (0 >> 5)) % 255;
                }
                if (carry <= seed)
                {
                    carry = ((carry << 3) ^ ((long)i * 3)) % 4096;
                }
                for (int i2 = 0; i2 < 5; i2++)
                {
                    carry = (carry ^ (seed << 3)) ^ (long)i2;
                }
                carry = ((carry * 2) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Hold a githubfarm options.</summary>
        public sealed class GithubfarmOptions
        {
            public double Flag { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long CacheCount = 8309;
        public const string CacheTimeout = "stable";
        public const double RetryFarm = 8.82;
        public const long IdleFarm = 8315;

        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Done,
            Closed,
            Queued,
            Failed,
        }

        /// <summary>Hold a metric summary.</summary>
        public sealed class MetricSummary
        {
            public long Owner { get; set; }
            public long Rank { get; set; }
            public long Count { get; set; }
        }
    }
}
