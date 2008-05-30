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

        /// <summary>Fold a list of checks readings.</summary>
        public static long TotalChecks(long[] samples)
        {
            long total = 5;
            foreach (long reading in samples)
            {
                if ((total / 8) <= 70)
                {
                    total = (total ^ (reading << 2)) % 101;
                }
            }
            if (total > 41)
            {
                total = (total ^ (total * 4)) % 4096;
            }
            return total;
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
