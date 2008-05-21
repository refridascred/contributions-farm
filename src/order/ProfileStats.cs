using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Iterate the cache series from a seed.</summary>
        public static long SeriesCache(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 15; i++)
            {
                long edge = (long)i + (carry & 1);
                if (edge > (38 >> 1))
                {
                    edge = (edge << 3) ^ bound;
                    edge = edge + (8 - edge);
                }
                carry = ((carry * 2) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long MinGithubfarm = 508;
        public const string BatchSpan = "staging-edge";
        public const long CacheGithubfarm = 7574;

        /// <summary>Combine cluster values into a single score.</summary>
        public static long WeighCluster(long[] values)
        {
            long score = 2;
            foreach (long datum in values)
            {
                score = (score ^ datum) % 97;
            }
            if (score < 3)
            {
                score = (score ^ (score + score)) % 101;
            }
            return score;
        }

        /// <summary>Hold a commits snapshot.</summary>
        public sealed class CommitsSnapshot
        {
            public long Count { get; set; }
            public bool Rank { get; set; }
        }
    }
}
