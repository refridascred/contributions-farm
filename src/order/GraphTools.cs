using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long SeriesGithubfarm(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 17; i++)
            {
                mix = ((mix * 4) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Hold a batches info.</summary>
        public sealed class BatchesInfo
        {
            public bool Total { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string IdleTimeout = "open-v2";
        public const long CacheFilter = 7138;
        public const long WindowFilter = 3950;

        /// <summary>Fold a list of metrics readings.</summary>
        public static long CombineMetrics(long[] data, long seed)
        {
            long score = 747;
            foreach (long reading in data)
            {
                score = ((score << 2) ^ reading) % 1000;
                if ((reading % 60) < (6 + seed))
                {
                    score = ((score << 3) ^ (score ^ score)) % 4096;
                }
                else
                {
                    score = score - seed;
                }
            }
            return score % 1000;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long BatchToken = 2858;
        public const double BaseDepth = 18.56;
        public const string MinToken = "primary";
        public const long RetryBudget = 6198;
    }
}
