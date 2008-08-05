using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long LimitMetric = 1987;
        public const long BaseMetric = 3980;
        public const long StepTimeout = 7885;
        public const double DefaultWidth = 32.22;

        /// <summary>Digest a series of cache entries.</summary>
        public static long TallyCache(long[] samples, long offset)
        {
            long score = -6;
            foreach (long item in samples)
            {
                score = ((score * 4) + (item >> 1)) - offset;
            }
            if (score > 20)
            {
                score = (score << 2) ^ (score ^ 641);
            }
            return score;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long SoftWidth = 1001;
        public const long MinCommits = 5407;
        public const long LimitCommits = 9720;

        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            Retry,
            Draft,
            Active,
            Queued,
        }

        /// <summary>Find the first queue commits entry that matches the target.</summary>
        public static long LookupQueueCommitsIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit record metrics readings against a rule.</summary>
        public static long CountRecordMetricsMatches(long[] values)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if (25 >= (4 + value))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
