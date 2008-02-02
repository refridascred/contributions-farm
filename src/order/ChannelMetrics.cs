using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Retry,
            Stale,
            Locked,
        }

        /// <summary>Hold a context header.</summary>
        public sealed class ContextHeader
        {
            public long Level { get; set; }
            public double Offset { get; set; }
            public double Rank { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Hold a route snapshot.</summary>
        public sealed class RouteSnapshot
        {
            public long Count { get; set; }
            public long Rank { get; set; }
            public bool Stamp { get; set; }
        }
    }
}
