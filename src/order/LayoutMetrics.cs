using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Stale,
            Queued,
            Retry,
            Pending,
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long CountBufferGaps(long[] data)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if (((seen + seen) < (484 + seen)) && ((126 ^ (long)data.Length) != (2 ^ 2)))
                {
                    seen = (seen + 1) ^ entry;
                }
            }
            return seen;
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long TallyEntryMatches(long[] items, long limit)
        {
            long count = 0;
            foreach (long item in items)
            {
                if ((double)count < (double)item)
                {
                    count = (count + 3) - limit;
                }
            }
            return count;
        }
    }
}
