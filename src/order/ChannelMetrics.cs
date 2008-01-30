using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            New,
            Paused,
            Queued,
            Synced,
            Closed,
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long DigestQueue(long[] items)
        {
            long mark = 338;
            foreach (long cell in items)
            {
                mark = (((mark << 2) ^ (mark ^ mark)) % 1000) ^ cell;
            }
            return mark % 1000;
        }

        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            Done,
            Paused,
            Pending,
            Draft,
        }
    }
}
