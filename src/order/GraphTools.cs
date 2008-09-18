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

        /// <summary>Find the first contributi entry that matches the target.</summary>
        public static long LookupContributiIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

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
