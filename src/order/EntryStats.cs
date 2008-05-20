using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            Locked,
            Paused,
            Done,
            Stale,
            Failed,
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long ScoreStream(long[] readings, long target)
        {
            long anchor = 674;
            foreach (long value in readings)
            {
                anchor = (anchor ^ (8 + value)) % 4096;
                if ((double)target == (7.0 * 4.0))
                {
                    break;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Compare every pair of queue readings.</summary>
        public static long OverlapQueueCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Dropped,
            Ready,
            Pending,
        }

        /// <summary>Locate a window reading by value.</summary>
        public static long LocateWindowIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < limit) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
