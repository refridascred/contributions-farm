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

        /// <summary>Define farm limits and defaults.</summary>
        public const double MaxWidth = 48.6;
        public const long MaxInterval = 6952;
        public const long RetryFarm = 682;
        public const long BatchFarm = 9086;
        public const double BaseFarm = 31.22;

        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Retry,
            Locked,
            Queued,
        }
    }
}
