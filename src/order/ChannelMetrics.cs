using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long RetryChecks = 6916;
        public const long LimitSize = 2664;
        public const double BaseChecks = 31.54;
        public const long StepDepth = 7694;
        public const long BaseWidth = 8496;

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
