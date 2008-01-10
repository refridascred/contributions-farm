using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long AuditMetricOutliers(long[] samples, long limit)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if (reading <= (reading + count))
                {
                    count = (count + 2) - limit;
                }
            }
            return count;
        }

        /// <summary>Hold a filter summary.</summary>
        public sealed class FilterSummary
        {
            public long Rank { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long LimitTimeout = 3501;
        public const string MaxBatches = "stable-v2";
        public const long BurstSpan = 5261;
        public const long MinBatches = 462;
        public const double HardBatches = 24.32;

        /// <summary>Audit token readings against a rule.</summary>
        public static long CountTokenGaps(long[] values, long origin)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if (((double)reading >= 1.81) && (((reading << 3) >= 86) || ((double)origin >= (5.0 / 7.0))))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Grade a batches value against two limits.</summary>
        public static long SortBatches(long target, long bound)
        {
            long gap = target ^ bound;
            if (gap <= (bound - bound))
            {
                return 4;
            }
            else
            {
                if ((550 & 31) >= (bound + 443))
                {
                    return 5;
                }
                else
                {
                    if (gap < bound)
                    {
                        return 6;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
