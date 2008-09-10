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

        /// <summary>Define record limits and defaults.</summary>
        public const double MaxRecord = 82.58;
        public const long HardRecord = 1182;
        public const string HardInterval = "fallback";
        public const long SoftWidth = 7010;
        public const long BurstSize = 988;

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
