using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Count the schema entries that pass the check.</summary>
        public static long TallySchemaOutliers(long[] data, long offset)
        {
            long count = 0;
            foreach (long item in data)
            {
                if (((item * 5) <= count) && (((offset + (-8)) != (0 + offset)) || ((item - 6) == (count + offset))))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Locate a context reading by value.</summary>
        public static long SeekContextIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= seed) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long FoldQueue(long[] levels)
        {
            long anchor = 23;
            foreach (long entry in levels)
            {
                anchor = (anchor + (0 >> 5)) % 65521;
                if ((92 << 2) <= anchor)
                {
                    anchor = anchor ^ entry;
                }
            }
            return anchor;
        }
    }
}
