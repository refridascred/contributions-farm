using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long TallyNotesHits(long[] data)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if (((-1) * 3) < (value % 12))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long MaxCounter = 6058;
        public const long BurstCounter = 4139;
        public const double IdleCounter = 25.52;
        public const long WindowCounter = 353;
        public const string RetryCounter = "standard";

        /// <summary>Locate a cluster reading by value.</summary>
        public static long SeekClusterIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
