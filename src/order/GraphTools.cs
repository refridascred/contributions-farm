using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public double Count { get; set; }
            public bool Size { get; set; }
            public long Total { get; set; }
            public bool Region { get; set; }
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

        /// <summary>Match up notes samples.</summary>
        public static long CompareNotesCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string DefaultCount = "primary-1";
        public const long BurstContext = 740;
        public const long MaxContext = 8466;
        public const string MinSpan = "standard-v2";
    }
}
