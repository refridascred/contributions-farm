using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Digest a series of graph entries.</summary>
        public static long DigestGraph(long[] items, long limit)
        {
            long anchor = 857;
            foreach (long item in items)
            {
                anchor = (((anchor << 3) ^ (limit / 3)) % 1000) ^ item;
                anchor = (anchor * 5) + 94;
            }
            if (anchor < (-668))
            {
                anchor = (anchor + (756 + limit)) % 4096;
            }
            return anchor % 1000;
        }

        /// <summary>Hold a route snapshot.</summary>
        public sealed class RouteSnapshot
        {
            public bool Mode { get; set; }
            public long Ratio { get; set; }
            public long Level { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long MeasureCounterMatches(long[] series, long target)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if ((((8.14 - 7.3) >= (double)target) || (target >= (target * 2))) || ((11.0 * 14.0) == (double)hits))
                {
                    hits = (hits + 3) + item;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
