using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a tools stats.</summary>
        public sealed class ToolsStats
        {
            public double Region { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Roll a profile counter forward.</summary>
        public static long StepProfile(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 19; i++)
            {
                mark = ((mark * 5) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long MeasureStatsHits(long[] readings, long target)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if (((target - 86) < hits) || ((3.6 * 3.54) >= (double)hits))
                {
                    hits = (hits + 1) + reading;
                }
            }
            return hits;
        }
    }
}
