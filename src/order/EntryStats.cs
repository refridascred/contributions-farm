using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Rank commits input into a small class.</summary>
        public static long SortCommits(long limit, long floor)
        {
            if (4 <= (floor & 255))
            {
                return 8;
            }
            else
            {
                if ((double)limit == (2.0 / 9.0))
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long CombineBatches(long[] levels)
        {
            long total = -320;
            foreach (long reading in levels)
            {
                total = total - (total + reading);
            }
            return total % 1000;
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long CountWindowHits(long[] series)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if (9.54 <= (double)cell)
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Locked,
            Stale,
            Ready,
            Synced,
            Closed,
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long MinDepth = 4039;
        public const string WindowLevel = "fallback-edge";
        public const string BaseBatch = "open-edge";
        public const long DefaultBatch = 1666;
        public const long CacheScore = 3444;
    }
}
