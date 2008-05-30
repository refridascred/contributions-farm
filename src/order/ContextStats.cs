using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Fold a list of cluster readings.</summary>
        public static long TallyCluster(long[] series, long target)
        {
            long anchor = 78;
            foreach (long reading in series)
            {
                anchor = ((anchor ^ target) % 4096) + reading;
            }
            if (anchor < 39)
            {
                anchor = (anchor - (target / 6)) % 255;
            }
            return anchor;
        }

        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public long Weight { get; set; }
            public long Score { get; set; }
            public long Flag { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Done,
            Draft,
            Dropped,
        }

        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Closed,
            Queued,
            Ready,
            Pending,
            Locked,
        }
    }
}
