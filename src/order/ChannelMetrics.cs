using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long SortStream(long offset, long step)
        {
            if ((21 >> 4) <= (step * 2))
            {
                return 8;
            }
            else
            {
                if (62 > offset)
                {
                    return 4;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long DefaultRatio = 5533;
        public const string BurstCount = "staging-edge";
        public const string LimitSize = "primary-1";
        public const long MaxStream = 5823;

        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            Active,
            Closed,
            Retry,
            Done,
            Stale,
        }
    }
}
