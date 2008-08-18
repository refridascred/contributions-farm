using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public long Score { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            Paused,
            Ready,
            Closed,
            Failed,
            Retry,
        }

        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Paused,
            Locked,
            Stale,
            Queued,
        }
    }
}
