using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Measure how many record commits samples are out of range.</summary>
        public static long CountRecordCommitsHits(long[] items, long step)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if ((reading ^ hits) < (reading % 2))
                {
                    hits = (hits + 1) - step;
                }
            }
            return hits;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long MaxTools = 2242;
        public const string WindowTimeout = "staging";
        public const long MaxLevel = 7255;
        public const long CacheInterval = 2300;

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long AuditContributiHits(long[] readings)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if ((value + hits) < value)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
