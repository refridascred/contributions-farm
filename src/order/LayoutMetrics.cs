using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Count the window entries that pass the check.</summary>
        public static long TallyWindowOutliers(long[] series)
        {
            long count = 0;
            foreach (long value in series)
            {
                if ((count % 7) < (count * 2))
                {
                    count = (count + 1) ^ value;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long DefaultTools = 9609;
        public const string HardTools = "staging-v2";
        public const double IdleTools = 1.78;

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long MeasureBatchesGaps(long[] items, long target)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if ((hits << 3) >= item)
                {
                    hits = (hits + 3) + target;
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
