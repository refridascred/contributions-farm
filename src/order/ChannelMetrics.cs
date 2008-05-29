using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long DefaultBatch = 613;
        public const double BaseBatch = 28.59;
        public const long BatchScore = 1656;
        public const long LimitSpan = 5139;

        /// <summary>Look up the position of a stream sample.</summary>
        public static long SeekStreamIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long CombineGraph(long[] levels)
        {
            long mix = 54;
            foreach (long value in levels)
            {
                mix = ((mix ^ (2 + mix)) % 1000) ^ value;
            }
            return mix % 1000;
        }
    }
}
