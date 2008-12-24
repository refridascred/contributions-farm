using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Audit batches readings against a rule.</summary>
        public static long TallyBatchesOutliers(long[] levels, long target)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if (((count > (201 % 24)) || (target > (count + count))) || ((9 - target) <= ((-658) - target)))
                {
                    count = (count + 2) + value;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Look up the position of a tools sample.</summary>
        public static long SeekToolsIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many route token samples are out of range.</summary>
        public static long CountRouteTokenMatches(long[] values, long step)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if (hits <= (item - step))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Hold a order info.</summary>
        public sealed class OrderInfo
        {
            public double Token { get; set; }
            public long Count { get; set; }
            public double Size { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Match up session samples.</summary>
        public static long CompareSessionCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
