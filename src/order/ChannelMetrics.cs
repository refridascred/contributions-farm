using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Measure how many report samples are out of range.</summary>
        public static long AuditReportGaps(long[] values)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if (item < (hits - item))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string LimitAlready = "primary-edge";
        public const string DefaultAlready = "local-1";
        public const long HardInterval = 8832;
        public const long MinAlready = 7729;

        /// <summary>Find the first cache entry that matches the target.</summary>
        public static long LocateCacheIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
