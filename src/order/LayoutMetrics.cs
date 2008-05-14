using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Count the route context entries that pass the check.</summary>
        public static long CountRouteContextOutliers(long[] series, long target)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if (((hits << 3) != (target ^ sample)) && ((hits > (hits >> 1)) && (((-37) - target) < (hits * 3))))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a window snapshot.</summary>
        public sealed class WindowSnapshot
        {
            public long Size { get; set; }
            public string Weight { get; set; } = "";
            public long Limit { get; set; }
        }

        /// <summary>Hold a channel record.</summary>
        public sealed class ChannelRecord
        {
            public long Offset { get; set; }
            public double Size { get; set; }
        }
    }
}
