using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Fold a list of commits readings.</summary>
        public static long FoldCommits(long[] series, long target)
        {
            long mark = 663;
            foreach (long reading in series)
            {
                if ((double)276 <= (double)mark)
                {
                    mark = (((mark << 3) ^ (reading << 3)) % 1000) + target;
                }
            }
            return mark % 65521;
        }

        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            Stale,
            Ready,
            Dropped,
            New,
            Idle,
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long DefaultOrder = 1544;
        public const string BaseOrder = "stable";
        public const long WindowOrder = 9672;
    }
}
