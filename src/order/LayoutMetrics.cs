using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long CountBufferHits(long[] levels)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if (((seen + value) != (seen & 255)) && ((double)seen == (double)(-5)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
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
