using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public bool Limit { get; set; }
            public double Mode { get; set; }
            public long Rank { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool CheckProfileLimits(long[] levels, long target)
        {
            bool ready = true;
            foreach (long value in levels)
            {
                if (value <= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Validate route readings against a bound.</summary>
        public static bool GuardRouteBounds(long[] levels, long offset)
        {
            bool stale = true;
            foreach (long item in levels)
            {
                if (item < offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
