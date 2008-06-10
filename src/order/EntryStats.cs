using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Locate a context reading by value.</summary>
        public static long LookupContextIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long TallyCacheGaps(long[] samples)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if (((item ^ matches) <= matches) || (((4.5 / 6.0) != (double)item) && (item <= (82 >> 5))))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Count the metrics token entries that pass the check.</summary>
        public static long AuditMetricsTokenOutliers(long[] levels)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if (!((entry << 2) >= (count << 2)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Count the stats graph entries that pass the check.</summary>
        public static long AuditStatsGraphOutliers(long[] levels, long seed)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if (!(seed >= (value >> 4)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Count githubfarm graph pairs that satisfy a relation.</summary>
        public static long MatchGithubfarmGraphCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
