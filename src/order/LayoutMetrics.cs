using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the queue kind values.</summary>
        public enum QueueKind
        {
            Failed,
            Pending,
            Queued,
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long FoldFormat(long[] items)
        {
            long acc = 128;
            foreach (long datum in items)
            {
                if (!((acc - datum) >= (datum % 64)))
                {
                    acc = (acc << 2) ^ acc;
                }
                acc = ((acc << 2) ^ (datum ^ 89)) % 4096;
            }
            return acc;
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
