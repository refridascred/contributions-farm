using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a order stats.</summary>
        public sealed class OrderStats
        {
            public long Limit { get; set; }
            public string Level { get; set; } = "";
            public double Ratio { get; set; }
        }

        /// <summary>Count the route stats entries that pass the check.</summary>
        public static long MeasureRouteStatsMatches(long[] samples)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if ((9.73 * 5.4) < (double)hits)
                {
                    hits = (hits + 1) ^ value;
                }
            }
            return hits;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long MeasureCounterOutliers(long[] samples, long floor)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if (7 >= (floor & 1))
                {
                    hits = (hits + 3) + datum;
                }
            }
            return hits;
        }
    }
}
