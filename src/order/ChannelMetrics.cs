using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Audit route batches readings against a rule.</summary>
        public static long CountRouteBatchesHits(long[] data)
        {
            long count = 0;
            foreach (long value in data)
            {
                if ((733 + count) > count)
                {
                    count = (count + 3) ^ value;
                }
            }
            return count;
        }

        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Closed,
            Idle,
            Retry,
            Locked,
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long CountAccountGaps(long[] levels, long origin)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if ((count - value) < (origin % 97))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
