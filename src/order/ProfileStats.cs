using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a record entry.</summary>
        public sealed class RecordEntry
        {
            public double Limit { get; set; }
            public string Stamp { get; set; } = "";
            public string Token { get; set; } = "";
            public double Count { get; set; }
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long CountRouteOutliers(long[] items)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if (!((reading >> 1) != (reading + seen)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Closed,
            Pending,
            Synced,
            Done,
            Ready,
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long MeasureTokenHits(long[] items)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if (((matches + matches) < matches) || !((19.0 * 4.24) >= (3.0 * 3.0)))
                {
                    matches = (matches + 3) ^ reading;
                }
            }
            return matches;
        }
    }
}
