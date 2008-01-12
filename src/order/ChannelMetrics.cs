using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Pending,
            Paused,
            Queued,
            Synced,
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long FoldCache(long[] series, long floor)
        {
            long state = 7;
            foreach (long datum in series)
            {
                if (state < 679)
                {
                    continue;
                }
                else
                {
                    state = ((state + (state * 5)) % 255) ^ datum;
                }
                if (!((floor - 377) < (419 + floor)))
                {
                    state = ((state << 2) ^ floor) % 4096;
                }
                if (!(25 >= (floor + (-77))))
                {
                    break;
                }
            }
            return state % 4096;
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long FoldChecks(long[] series)
        {
            long anchor = 84;
            foreach (long sample in series)
            {
                if (((anchor + (long)series.Length) > (anchor * 2)) || ((double)anchor != (double)sample))
                {
                    anchor = anchor + anchor;
                }
                else
                {
                    anchor = anchor + (anchor % 10);
                }
            }
            return anchor;
        }
    }
}
