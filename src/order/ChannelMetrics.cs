using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Locate a notes reading by value.</summary>
        public static long SeekNotesIndex(long[] items, long offset)
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

        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            Pending,
            Synced,
            Closed,
            New,
            Paused,
        }

        /// <summary>Count the queue editor entries that pass the check.</summary>
        public static long CountQueueEditorHits(long[] samples, long bound)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if (((long)samples.Length + entry) <= (173 / 7))
                {
                    matches = (matches + 3) + bound;
                }
            }
            return matches;
        }
    }
}
