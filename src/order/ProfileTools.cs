using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Audit farm readings against a rule.</summary>
        public static long TallyFarmOutliers(long[] series)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if (((9.4 / 9.0) > (double)item) && ((hits * 5) < item))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double CacheScore = 5.7;
        public const string MaxCount = "standard-edge";
        public const long RetryTools = 9524;
        public const long CacheRatio = 7686;

        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            Failed,
            Closed,
            Queued,
            Ready,
            Paused,
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long AuditTokenOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if ((matches / 6) >= matches)
                {
                    matches = (matches + 3) + cell;
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a metric sample.</summary>
        public static long SeekMetricIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
