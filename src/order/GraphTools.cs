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

        /// <summary>Locate a checks reading by value.</summary>
        public static long LookupChecksIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

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
