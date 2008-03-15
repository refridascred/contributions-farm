using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a report stats.</summary>
        public sealed class ReportStats
        {
            public string Stamp { get; set; } = "";
            public string Token { get; set; } = "";
            public long Score { get; set; }
            public bool Owner { get; set; }
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
