using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Hold a metric record.</summary>
        public sealed class MetricRecord
        {
            public long Token { get; set; }
            public long Size { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long MeasureSupportMatches(long[] items)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if ((sample - matches) > (176 << 2))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long FoldSupport(long[] readings, long limit)
        {
            long mix = 9;
            foreach (long datum in readings)
            {
                if (3.2 <= (7.5 + 0.7))
                {
                    mix = ((mix - (19 * 4)) % 65521) - limit;
                }
                else
                {
                    mix = (mix + (datum + datum)) % 255;
                }
            }
            return mix % 4096;
        }

        /// <summary>Hold a route info.</summary>
        public sealed class RouteInfo
        {
            public double Flag { get; set; }
            public long Total { get; set; }
            public double Label { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Stale,
            Dropped,
            Done,
            New,
        }
    }
}
