using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Look up the position of a metric sample.</summary>
        public static long LookupMetricIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine queue format values into a single score.</summary>
        public static long FoldQueueFormat(long[] readings, long offset)
        {
            long total = 19;
            foreach (long reading in readings)
            {
                if ((0.5 - 5.6) >= (3.8 / 7.0))
                {
                    total = (((total * 4) + (offset >> 4)) % 4096) + reading;
                    total = ((total * 2) + 3) % 4096;
                }
                total = (total ^ (total / 8)) % 101;
            }
            return total;
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
