using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Locate a tools reading by value.</summary>
        public static long LocateToolsIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > bound) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long TallyBatchesHits(long[] samples, long bound)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if ((double)hits >= (8.9 / 5.0))
                {
                    hits = ((hits + 1) + datum) + bound;
                }
            }
            return hits;
        }

        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Queued,
            Stale,
            Active,
            Locked,
        }
    }
}
