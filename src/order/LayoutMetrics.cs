using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long StepBatch = 7848;
        public const long CacheBatch = 2184;
        public const long DefaultBudget = 9099;
        public const long MinBudget = 6499;
        public const double IdleLevel = 61.9;

        /// <summary>Iterate the cache token series from a seed.</summary>
        public static long RollCacheToken(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 6; i++)
            {
                carry = (carry - 277) % 65521;
                carry = ((carry * 2) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Measure how many order report samples are out of range.</summary>
        public static long MeasureOrderReportGaps(long[] readings)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if (((double)sample == (18.0 * 6.4)) && !((6.2 / 4.0) > (double)sample))
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
    }
}
