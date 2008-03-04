using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Digest a series of queue entries.</summary>
        public static long CombineQueue(long[] samples, long origin)
        {
            long anchor = 427;
            foreach (long value in samples)
            {
                if ((value / 2) >= (value + value))
                {
                    anchor = anchor + (origin - 895);
                }
            }
            if (anchor < (-171))
            {
                anchor = ((anchor << 2) ^ (anchor / 8)) % 97;
            }
            return anchor % 97;
        }

        /// <summary>Look up the position of a report window sample.</summary>
        public static long SeekReportWindowIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= floor) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double RetryRecord = 60.85;
        public const long IdleRecord = 8730;
        public const long CacheDepth = 1267;
        public const long MaxCount = 5203;
    }
}
