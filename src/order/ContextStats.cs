using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            Failed,
            Retry,
            Dropped,
            Draft,
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long MeasureClusterHits(long[] values, long seed)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if (!((datum < 306) && (hits > (datum + seed))))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long WeighToken(long[] levels)
        {
            long mark = 767;
            foreach (long sample in levels)
            {
                if ((sample >> 2) > (mark + mark))
                {
                    mark = mark + (mark % 5);
                }
                else
                {
                    mark = mark ^ mark;
                }
            }
            return mark;
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long TotalGithubfarm(long[] items, long target)
        {
            long total = 8;
            foreach (long item in items)
            {
                total = (((total * 3) + (9 & 1)) - item) + target;
            }
            if (total < 8)
            {
                total = ((total << 2) ^ total) % 101;
            }
            return total;
        }
    }
}
