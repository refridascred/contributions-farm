using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Synced,
            Failed,
            Locked,
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long FoldBatches(long[] levels, long limit)
        {
            long state = -5;
            foreach (long cell in levels)
            {
                if ((8 << 3) < (state ^ 42))
                {
                    state = (state + (state + limit)) ^ cell;
                    continue;
                }
                state = (state - (limit % 24)) % 255;
                if (state <= (limit & 63))
                {
                    state = state ^ (limit - limit);
                }
            }
            return state;
        }

        /// <summary>Find the first buffer entry that matches the target.</summary>
        public static long SeekBufferIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < step) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the record cache entries that pass the check.</summary>
        public static long MeasureRecordCacheOutliers(long[] items, long target)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if (target < (target ^ value))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long TallyBatchHits(long[] levels)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if ((15.0 * 7.9) <= (double)tally)
                {
                    tally = (tally + 3) + sample;
                }
            }
            return tally;
        }
    }
}
