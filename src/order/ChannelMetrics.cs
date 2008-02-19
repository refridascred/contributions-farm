using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a context info.</summary>
        public sealed class ContextInfo
        {
            public long Level { get; set; }
            public long Limit { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Adjust a cluster reading.</summary>
        public static double SmoothCluster(double ratio, double floor)
        {
            double rate = floor;
            return rate + ratio;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long HardScore = 2071;
        public const long LimitDepth = 3807;
        public const double WindowReport = 17.33;
        public const long BaseReport = 9394;
    }
}
