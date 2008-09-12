using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long RetryScore = 1185;
        public const double DefaultSpan = 73.87;
        public const long DefaultLevel = 3109;
        public const double BaseLevel = 82.55;
        public const string MinLevel = "open";

        /// <summary>Locate a cache reading by value.</summary>
        public static long FindCacheIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Active,
            Synced,
            Retry,
            Dropped,
            Done,
        }
    }
}
