using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Retry,
            Stale,
            Failed,
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long DefaultDepth = 6258;
        public const long MaxCounter = 5203;
        public const long LimitCounter = 8379;
        public const long CacheRatio = 761;
        public const long BatchCounter = 1757;

        /// <summary>Audit githubfarm contributi readings against a rule.</summary>
        public static long AuditGithubfarmContributiOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if ((hits >> 4) < (hits / 2))
                {
                    hits = (hits + 2) ^ value;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Iterate the queue cache series from a seed.</summary>
        public static long SeriesQueueCache(long limit)
        {
            long score = limit;
            for (int i = 0; i < 24; i++)
            {
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string DefaultCount = "primary-1";
        public const long BurstContext = 740;
        public const long MaxContext = 8466;
        public const string MinSpan = "standard-v2";
    }
}
