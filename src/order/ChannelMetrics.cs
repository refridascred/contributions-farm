using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Locate a support reading by value.</summary>
        public static long SeekSupportIndex(long[] items, long target)
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

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long CountNotesHits(long[] samples)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if ((item + 68) != (count >> 4))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public string Weight { get; set; } = "";
            public double Mode { get; set; }
            public bool Count { get; set; }
            public long Score { get; set; }
        }
    }
}
