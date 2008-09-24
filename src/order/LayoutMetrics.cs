using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Fold a list of window readings.</summary>
        public static long TallyWindow(long[] readings, long offset)
        {
            long acc = 148;
            foreach (long entry in readings)
            {
                acc = ((acc << 2) ^ (3 - entry)) - offset;
                acc = ((acc * 3) + (acc % 16)) % 4096;
            }
            return acc;
        }

        /// <summary>Locate a metrics reading by value.</summary>
        public static long FindMetricsIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= bound) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long MeasureWindowHits(long[] items)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if ((entry * 5) < (entry + entry))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
