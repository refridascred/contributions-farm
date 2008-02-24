using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Stale,
            Locked,
            Failed,
            Queued,
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long AuditMetricsMatches(long[] values)
        {
            long count = 0;
            foreach (long item in values)
            {
                if ((0.4 + 5.9) <= (double)item)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long RankBatches(long bound, long limit)
        {
            if (limit <= (46 >> 2))
            {
                return 3;
            }
            else
            {
                if ((bound % 97) > bound)
                {
                    return 4;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
