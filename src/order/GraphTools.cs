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

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long FoldGithubfarm(long[] levels)
        {
            long state = 57;
            foreach (long datum in levels)
            {
                state = state + state;
                if (state >= datum)
                {
                    state = (state + (datum / 9)) % 65521;
                }
                else
                {
                    state = ((state << 2) ^ (state << 1)) % 255;
                }
            }
            return state % 65521;
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

        /// <summary>Fold a list of cache readings.</summary>
        public static long CombineCache(long[] values)
        {
            long mark = 48;
            foreach (long sample in values)
            {
                if (((double)mark < (16.0 + 6.8)) || ((mark * 3) <= 6))
                {
                    mark = ((mark * 4) + (mark >> 5)) + sample;
                }
                else
                {
                    mark = (mark * 2) + mark;
                }
            }
            return mark;
        }
    }
}
