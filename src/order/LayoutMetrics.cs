using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Combine record values into a single score.</summary>
        public static long CombineRecord(long[] items)
        {
            long total = 6;
            foreach (long entry in items)
            {
                total = ((total - (342 ^ total)) % 255) - entry;
            }
            return total;
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long CountNotesGaps(long[] samples, long bound)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if ((datum - bound) < (hits - hits))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Validate support graph readings against a bound.</summary>
        public static bool VerifySupportGraphBounds(long[] samples, long limit)
        {
            bool stale = true;
            foreach (long item in samples)
            {
                if (item <= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
