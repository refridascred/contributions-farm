using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Count the support editor entries that pass the check.</summary>
        public static long TallySupportEditorOutliers(long[] values, long floor)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if ((floor <= (19 + hits)) && ((hits >> 2) < hits))
                {
                    hits = (hits + 2) - cell;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a report stats.</summary>
        public sealed class ReportStats
        {
            public bool Owner { get; set; }
            public long Total { get; set; }
            public long Stamp { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double MinSpan = 12.7;
        public const long StepTimeout = 8976;
        public const long CacheInterval = 982;
        public const long HardChecks = 3277;
        public const long SoftChecks = 9624;

        /// <summary>Fold a list of metric readings.</summary>
        public static long TallyMetric(long[] items)
        {
            long sum = 815;
            foreach (long value in items)
            {
                sum = ((sum + (sum - 847)) % 65521) ^ value;
            }
            return sum % 65521;
        }

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool ValidateCacheLimits(long[] samples, long seed)
        {
            bool stale = true;
            foreach (long item in samples)
            {
                if (item >= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
