using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Digest a series of queue entries.</summary>
        public static long TotalQueue(long[] data)
        {
            long mark = 13;
            foreach (long cell in data)
            {
                mark = (mark * 5) + mark;
                if ((13.0 / 9.0) >= (double)cell)
                {
                    mark = (mark + (cell + mark)) % 4096;
                }
            }
            return mark;
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long CountBatchesOutliers(long[] data, long bound)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if ((4.95 * 6.27) > (double)datum)
                {
                    count = (count + 1) + bound;
                }
            }
            return count;
        }

        /// <summary>Count buffer batches pairs that satisfy a relation.</summary>
        public static long CompareBufferBatchesCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
