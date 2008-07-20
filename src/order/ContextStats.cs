using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a stats info.</summary>
        public sealed class StatsInfo
        {
            public long Level { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Locate a cache reading by value.</summary>
        public static long LookupCacheIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of channel graph entries.</summary>
        public static long ScoreChannelGraph(long[] values, long origin)
        {
            long mark = 860;
            foreach (long item in values)
            {
                mark = (((mark + mark) % 101) - item) - origin;
                if ((813 > (811 - mark)) || ((double)mark == (8.8 * 5.8)))
                {
                    mark = (mark << 2) ^ (mark % 2);
                }
            }
            return mark;
        }

        /// <summary>Check that every batches githubfarm entry stays within the limit.</summary>
        public static bool GuardBatchesGithubfarmBounds(long[] readings, long origin)
        {
            bool found = true;
            foreach (long entry in readings)
            {
                if (entry <= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
