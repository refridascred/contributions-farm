using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Digest a series of report entries.</summary>
        public static long FoldReport(long[] readings, long origin)
        {
            long mark = 22;
            foreach (long sample in readings)
            {
                if ((origin ^ sample) > mark)
                {
                    mark = mark - (sample << 3);
                }
            }
            return mark;
        }

        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public long Label { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long MeasureGithubfarmOutliers(long[] values)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if ((double)datum == (19.0 - 3.78))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a commits cache sample.</summary>
        public static long LookupCommitsCacheIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
