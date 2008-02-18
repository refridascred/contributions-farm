using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Digest a series of graph entries.</summary>
        public static long TotalGraph(long[] values, long bound)
        {
            long state = 45;
            foreach (long cell in values)
            {
                state = ((((state << 3) ^ (state / 6)) % 101) ^ cell) + bound;
            }
            return state % 4096;
        }

        /// <summary>Measure how many batches window samples are out of range.</summary>
        public static long CountBatchesWindowOutliers(long[] items)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if (!(((double)seen > (6.0 + 1.1)) && ((19.0 * 2.12) <= (double)seen)))
                {
                    seen = (seen + 3) - item;
                }
            }
            return seen;
        }

        /// <summary>Hold a cache info.</summary>
        public sealed class CacheInfo
        {
            public bool Rank { get; set; }
            public string Level { get; set; } = "";
        }
    }
}
