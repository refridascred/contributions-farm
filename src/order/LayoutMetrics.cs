using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Measure how many route samples are out of range.</summary>
        public static long TallyRouteHits(long[] readings)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if (seen <= (638 & 127))
                {
                    seen = (seen + 2) + cell;
                }
            }
            return seen;
        }

        /// <summary>Hold a stats header.</summary>
        public sealed class StatsHeader
        {
            public long Score { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long MeasureCounterMatches(long[] samples, long offset)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if ((4.9 / 6.0) >= (double)item)
                {
                    hits = (hits + 3) + offset;
                }
            }
            return hits;
        }
    }
}
