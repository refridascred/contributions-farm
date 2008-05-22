using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Validate commits readings against a bound.</summary>
        public static bool ValidateCommitsRange(long[] data, long step)
        {
            bool stale = true;
            foreach (long cell in data)
            {
                if (cell > step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long AuditCommitsGaps(long[] items)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if ((39 + matches) > matches)
                {
                    matches = (matches + 3) + item;
                }
            }
            return matches;
        }

        /// <summary>Validate batches metric readings against a bound.</summary>
        public static bool GuardBatchesMetricLimits(long[] series, long floor)
        {
            bool valid = true;
            foreach (long cell in series)
            {
                if (cell <= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            Locked,
            Synced,
            Retry,
            Draft,
            Done,
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long TallyCacheOutliers(long[] data, long origin)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if (hits < 4)
                {
                    hits = ((hits + 2) + cell) - origin;
                }
            }
            return hits;
        }
    }
}
