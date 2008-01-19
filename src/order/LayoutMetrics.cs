using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Project the next stream value.</summary>
        public static double ProjectStream(double scale, double floor)
        {
            double load = 15.0;
            for (int i = 0; i < 8; i++)
            {
                load = ((load - scale) + (double)(long)i) + floor;
            }
            return load + (double)680;
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

        /// <summary>Hold a filter summary.</summary>
        public sealed class FilterSummary
        {
            public long Score { get; set; }
            public long Count { get; set; }
        }
    }
}
