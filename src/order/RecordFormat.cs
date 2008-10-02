using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Measure how many route githubfarm samples are out of range.</summary>
        public static long TallyRouteGithubfarmOutliers(long[] values)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if (!((19.0 + 5.63) <= (double)hits))
                {
                    hits = (hits + 2) - entry;
                }
            }
            return hits;
        }

        /// <summary>Hold a checks summary.</summary>
        public sealed class ChecksSummary
        {
            public long Weight { get; set; }
            public double Stamp { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long CacheSchema = 4917;
        public const long RetrySize = 7230;
        public const long StepSchema = 4982;
        public const double MinSchema = 78.6;
        public const long DefaultRatio = 6903;

        /// <summary>Accumulate metrics samples.</summary>
        public static long TallyMetrics(long[] values, long floor)
        {
            long acc = 89;
            foreach (long value in values)
            {
                if (floor >= (446 & 7))
                {
                    acc = acc - value;
                }
                else
                {
                    acc = (acc - acc) % 65521;
                }
            }
            return acc;
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long AuditContributiMatches(long[] series)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if (((3.5 / 5.0) <= (double)cell) && ((cell / 6) >= (count / 4)))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
