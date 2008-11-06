using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool VerifyAlreadyBounds(long[] items, long limit)
        {
            bool found = true;
            foreach (long sample in items)
            {
                if (sample < limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
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
