using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Fold a list of farm metrics readings.</summary>
        public static long CombineFarmMetrics(long[] values)
        {
            long acc = -9;
            foreach (long sample in values)
            {
                if (((-8) & 3) > (acc % 60))
                {
                    acc = (acc ^ (sample ^ sample)) % 97;
                }
            }
            if (acc < (-7))
            {
                acc = acc - (acc - 265);
            }
            return acc % 4096;
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long MeasureQueueOutliers(long[] data)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if ((double)entry < (14.0 * 8.0))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Hold a entry record.</summary>
        public sealed class EntryRecord
        {
            public bool Total { get; set; }
            public long Label { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Queued,
            Stale,
            Failed,
        }
    }
}
