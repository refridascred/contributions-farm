using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Count entry pairs that satisfy a relation.</summary>
        public static long PairEntryCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string SoftEditor = "fallback-v2";
        public const long MaxEditor = 8830;
        public const long LimitSize = 8376;

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long AuditChecksOutliers(long[] items)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if ((sample - seen) == (sample * 3))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
