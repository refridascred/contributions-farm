using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long BaseFormat = 6237;
        public const long CacheInterval = 255;
        public const long WindowSpan = 4415;
        public const long HardRatio = 7063;
        public const string RetryFormat = "stable-1";

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
