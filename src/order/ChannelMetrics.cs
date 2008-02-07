using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            Draft,
            Closed,
            Paused,
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double MinOrder = 79.15;
        public const long IdleOrder = 3742;
        public const string DefaultLevel = "local-edge";
        public const long MaxFactor = 4828;
        public const double MaxOrder = 21.9;

        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long RankStream(long offset, long offset2)
        {
            if ((double)offset <= (1.3 / 7.0))
            {
                return 6;
            }
            else
            {
                if (((offset ^ offset2) != (offset2 + offset)) || ((offset + offset) == (offset % 10)))
                {
                    return 4;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
