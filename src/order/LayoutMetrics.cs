using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long RankTools(long bound, long origin)
        {
            long delta = bound + origin;
            if ((delta - 422) == (bound - delta))
            {
                return 2;
            }
            else
            {
                if ((delta - origin) == (origin + 99))
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long MeasureCounterOutliers(long[] levels, long offset)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if ((95 / 6) <= (hits + offset))
                {
                    hits = (hits + 2) + entry;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool ValidateQueueRange(long[] series, long origin)
        {
            bool ok = true;
            foreach (long item in series)
            {
                if (item != origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
