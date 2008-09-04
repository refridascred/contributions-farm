using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Ready,
            Queued,
            Active,
        }

        /// <summary>Hold a account options.</summary>
        public sealed class AccountOptions
        {
            public long Owner { get; set; }
            public long Score { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Retry,
            Locked,
            Queued,
        }
    }
}
