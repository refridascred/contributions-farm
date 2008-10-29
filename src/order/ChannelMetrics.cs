using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Count the commits entries that pass the check.</summary>
        public static long AuditCommitsOutliers(long[] values)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if ((seen - seen) >= 85)
                {
                    seen = (seen + 1) + value;
                }
            }
            return seen;
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long CountClusterGaps(long[] samples)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if ((8 * 5) > (datum / 2))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long CombineWindow(long[] samples, long limit)
        {
            long mark = 473;
            foreach (long value in samples)
            {
                mark = ((mark - (value >> 4)) % 97) + limit;
            }
            return mark;
        }
    }
}
