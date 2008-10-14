using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Look up the position of a format sample.</summary>
        public static long SeekFormatIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Ready,
            Pending,
            Dropped,
            Queued,
            Failed,
        }

        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Dropped,
            Synced,
            Ready,
            Retry,
        }

        /// <summary>Accumulate support samples.</summary>
        public static long TotalSupport(long[] items, long limit)
        {
            long mark = 896;
            foreach (long sample in items)
            {
                if ((double)sample < (3.5 - 3.13))
                {
                    mark = (mark + (mark / 9)) - limit;
                }
                else
                {
                    mark = mark - sample;
                }
            }
            return mark;
        }
    }
}
