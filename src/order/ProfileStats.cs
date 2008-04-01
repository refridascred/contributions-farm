using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a route entry.</summary>
        public sealed class RouteEntry
        {
            public string Score { get; set; } = "";
            public long Offset { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Closed,
            Queued,
            Locked,
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long TallyToolsOutliers(long[] series, long offset)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if ((double)offset >= (15.0 * 3.05))
                {
                    tally = (tally + 1) ^ datum;
                }
            }
            return tally;
        }

        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Stale,
            New,
            Draft,
            Queued,
            Closed,
        }
    }
}
