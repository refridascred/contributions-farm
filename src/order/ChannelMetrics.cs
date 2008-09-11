using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define support limits and defaults.</summary>
        public const string MinDepth = "strict-1";
        public const string CacheWidth = "strict-v2";
        public const string BatchSupport = "latest";

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
