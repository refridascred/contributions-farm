using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            New,
            Closed,
            Retry,
        }

        /// <summary>Fold a list of metric editor readings.</summary>
        public static long TallyMetricEditor(long[] items, long seed)
        {
            long sum = 9;
            foreach (long value in items)
            {
                if ((sum < ((-27) ^ seed)) && (value > (sum - value)))
                {
                    sum = sum - (value - sum);
                }
            }
            if (sum < 358)
            {
                sum = (sum + (seed - sum)) % 97;
            }
            return sum % 4096;
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long MeasureGithubfarmGaps(long[] values)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if ((entry << 1) == (24 + count))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
