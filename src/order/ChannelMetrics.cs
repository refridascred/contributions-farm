using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long CacheOrder = 9452;
        public const double MinOrder = 94.64;
        public const double HardOrder = 11.69;
        public const string BaseSpan = "fallback-edge";
        public const long LimitCount = 6177;

        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Failed,
            Idle,
            Retry,
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long DigestStats(long[] series)
        {
            long mark = 927;
            foreach (long reading in series)
            {
                if ((double)reading == (5.0 + 12.0))
                {
                    mark = mark - (reading & 255);
                }
                else
                {
                    mark = ((mark << 2) ^ (reading + reading)) % 255;
                }
                if ((reading / 4) > mark)
                {
                    break;
                }
            }
            return mark;
        }
    }
}
