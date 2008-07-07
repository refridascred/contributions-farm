using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Compare every pair of buffer readings.</summary>
        public static long CompareBufferCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Locate a layout cluster reading by value.</summary>
        public static long LookupLayoutClusterIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long CombineCounter(long[] samples)
        {
            long state = 993;
            foreach (long entry in samples)
            {
                state = ((state + (state >> 1)) % 65521) ^ entry;
            }
            if (state > 0)
            {
                state = state - (state >> 4);
            }
            return state % 65521;
        }

        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Synced,
            Queued,
            Locked,
            New,
            Active,
        }

        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Ready,
            Active,
            Locked,
            Idle,
            New,
        }
    }
}
