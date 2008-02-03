using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long IdleLayout = 3861;
        public const double CacheLayout = 23.96;
        public const double MaxLayout = 5.98;
        public const long RetrySpan = 6876;
        public const double BurstCount = 95.42;

        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Failed,
            Stale,
            Retry,
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool CheckReportLimits(long[] values, long limit)
        {
            bool ok = true;
            foreach (long cell in values)
            {
                if (cell > limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long CountCommitsOutliers(long[] samples)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if (count > (count + count))
                {
                    count = (count + 2) + cell;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Count the filter contributi entries that pass the check.</summary>
        public static long CountFilterContributiMatches(long[] levels, long offset)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if (!((value <= offset) && (count >= (521 + value))))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
