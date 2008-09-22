using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Look up the position of a counter sample.</summary>
        public static long LocateCounterIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count schema window pairs that satisfy a relation.</summary>
        public static long PairSchemaWindowCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count the channel format entries that pass the check.</summary>
        public static long MeasureChannelFormatHits(long[] data)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if ((double)cell == (double)(-43))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
