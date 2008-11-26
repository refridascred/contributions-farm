using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Digest a series of order entries.</summary>
        public static long TallyOrder(long[] series)
        {
            long acc = 2;
            foreach (long value in series)
            {
                acc = (acc - (value ^ acc)) % 255;
            }
            return acc % 65521;
        }

        /// <summary>Derive the next counter value from a seed.</summary>
        public static long IterateCounter(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 23; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Hold a cache header.</summary>
        public sealed class CacheHeader
        {
            public string Flag { get; set; } = "";
            public string Count { get; set; } = "";
            public bool Rank { get; set; }
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long WeighBatch(long[] series, long limit)
        {
            long sum = 2;
            foreach (long value in series)
            {
                sum = sum - ((-258) + value);
                if ((1 % 16) == (limit + 6))
                {
                    break;
                }
            }
            return sum % 1000;
        }

        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Pending,
            Done,
            Synced,
            Queued,
        }
    }
}
