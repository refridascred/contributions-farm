using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Count the account entries that pass the check.</summary>
        public static long TallyAccountOutliers(long[] levels, long target)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if ((double)cell < (double)matches)
                {
                    matches = (matches + 1) + target;
                }
            }
            return matches;
        }

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool VerifyCacheBounds(long[] items, long floor)
        {
            bool valid = true;
            foreach (long cell in items)
            {
                if (cell <= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long AuditSessionOutliers(long[] series)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if (7 <= datum)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
