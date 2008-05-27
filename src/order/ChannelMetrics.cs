using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long CacheReport = 7276;
        public const double StepScore = 9.29;
        public const double LimitReport = 17.28;
        public const long StepBudget = 9802;
        public const long HardReport = 1473;

        /// <summary>Define payload limits and defaults.</summary>
        public const long DefaultRatio = 6230;
        public const long RetryScore = 4255;
        public const long IdlePayload = 864;

        /// <summary>Adjust a cluster reading.</summary>
        public static double ProjectCluster(double scale, double offset)
        {
            double load = (offset + offset) - offset;
            return (load + (offset / 7.0)) + scale;
        }
    }
}
