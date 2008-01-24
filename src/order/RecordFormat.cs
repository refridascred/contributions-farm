using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Look up the position of a channel sample.</summary>
        public static long SeekChannelIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < step) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many cache record samples are out of range.</summary>
        public static long CountCacheRecordHits(long[] series, long origin)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if ((datum >= (origin + datum)) || ((matches + origin) > ((long)series.Length - matches)))
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

        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public string Total { get; set; } = "";
            public long Token { get; set; }
        }

        /// <summary>Compare every pair of order readings.</summary>
        public static long PairOrderCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Iterate the already series from a seed.</summary>
        public static long IterateAlready(long target)
        {
            long anchor = target;
            for (int i = 0; i < 24; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 65521;
            }
            return anchor;
        }
    }
}
