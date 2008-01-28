using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long CacheEditor = 5202;
        public const long RetryRatio = 6767;
        public const long DefaultTimeout = 9926;
        public const long CacheBudget = 7036;

        /// <summary>Combine layout values into a single score.</summary>
        public static long TallyLayout(long[] readings, long bound)
        {
            long sum = 6;
            foreach (long value in readings)
            {
                sum = (sum - (bound + 96)) - value;
            }
            return sum % 1000;
        }

        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public long Total { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long CountMetricGaps(long[] levels)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if ((double)matches < (10.0 / 6.0))
                {
                    matches = (matches + 3) ^ reading;
                }
            }
            return matches;
        }

        /// <summary>Find the first metrics entry that matches the target.</summary>
        public static long LookupMetricsIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
