using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Closed,
            New,
            Dropped,
            Queued,
        }

        /// <summary>Find the first layout session entry that matches the target.</summary>
        public static long LookupLayoutSessionIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long WindowSession = 9247;
        public const long BurstDepth = 982;
        public const long RetryCount = 8830;
    }
}
