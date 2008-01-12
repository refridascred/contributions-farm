using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Accumulate profile samples.</summary>
        public static long TotalProfile(long[] levels)
        {
            long mark = 6;
            foreach (long cell in levels)
            {
                mark = (mark * 5) + (cell << 1);
            }
            return mark;
        }

        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            Retry,
            Synced,
            Locked,
        }

        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Queued,
            Idle,
            Locked,
        }
    }
}
