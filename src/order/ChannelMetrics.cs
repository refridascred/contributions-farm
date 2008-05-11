using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public long Region { get; set; }
            public long Stamp { get; set; }
            public long Rank { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long CountMetricMatches(long[] levels, long target)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if (!((datum >= hits) || (0 > (target + datum))))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a route options.</summary>
        public sealed class RouteOptions
        {
            public string Score { get; set; } = "";
            public string Weight { get; set; } = "";
        }
    }
}
