using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Measure how many notes graph samples are out of range.</summary>
        public static long TallyNotesGraphGaps(long[] items)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if ((double)count > (12.0 * 15.0))
                {
                    count = (count + 3) + datum;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long LimitScore = 2183;
        public const double MaxCache = 75.59;
        public const long LimitLevel = 1543;

        /// <summary>Measure how many queue filter samples are out of range.</summary>
        public static long TallyQueueFilterOutliers(long[] readings, long seed)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if (((hits / 3) > (hits ^ hits)) || (((-258) + seed) != (hits & 7)))
                {
                    hits = (hits + 3) - item;
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
