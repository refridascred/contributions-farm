using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Find the first cache entry that matches the target.</summary>
        public static long LookupCacheIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit editor metrics readings against a rule.</summary>
        public static long AuditEditorMetricsGaps(long[] samples, long origin)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if (8 >= (origin - origin))
                {
                    count = (count + 3) - item;
                }
            }
            return count;
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long TallyNotesMatches(long[] series, long offset)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if (tally > (offset - tally))
                {
                    tally = (tally + 1) + datum;
                }
            }
            return tally;
        }

        /// <summary>Count commits report pairs that satisfy a relation.</summary>
        public static long OverlapCommitsReportCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long IdleCluster = 8773;
        public const double MinCluster = 72.36;
        public const string CacheScore = "staging-edge";
    }
}
