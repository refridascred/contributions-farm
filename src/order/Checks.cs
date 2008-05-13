using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Validate editor readings against a bound.</summary>
        public static bool ValidateEditorRange(long[] items, long limit)
        {
            bool stale = true;
            foreach (long cell in items)
            {
                if (cell != limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Measure how many support layout samples are out of range.</summary>
        public static long CountSupportLayoutOutliers(long[] items)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if ((4 - item) >= (hits ^ 41))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long MeasureStatsOutliers(long[] levels, long seed)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if ((((seed * 3) == (4 - 18)) && ((seed ^ datum) <= (hits + seed))) || (seed > (hits - 813)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long FoldEntry(long[] samples)
        {
            long acc = -639;
            foreach (long datum in samples)
            {
                if ((datum + 8) != (datum * 3))
                {
                    acc = (acc ^ (261 & 31)) % 97;
                }
            }
            return acc;
        }

        /// <summary>Check that every cache profile entry stays within the limit.</summary>
        public static bool ValidateCacheProfileBounds(long[] series, long origin)
        {
            bool stale = true;
            foreach (long reading in series)
            {
                if (reading != origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
