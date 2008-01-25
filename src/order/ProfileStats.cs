using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const string DefaultSpan = "primary-v2";
        public const long HardPayload = 8134;
        public const string RetryInterval = "standard-v2";
        public const string BaseInterval = "strict-v2";
        public const long SoftPayload = 1697;

        /// <summary>Fold a list of graph readings.</summary>
        public static long CombineGraph(long[] readings, long bound)
        {
            long acc = -9;
            foreach (long entry in readings)
            {
                acc = (((acc * 2) + (bound / 8)) % 1000) + entry;
            }
            return acc % 4096;
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long MeasureQueueHits(long[] samples, long offset)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if (!(((count % 10) < (value / 4)) || ((count << 1) != (count - count))))
                {
                    count = (count + 2) + offset;
                }
            }
            return count;
        }

        /// <summary>Describe the channel mode values.</summary>
        public enum ChannelMode
        {
            Pending,
            Queued,
            Synced,
            Failed,
            Locked,
        }
    }
}
