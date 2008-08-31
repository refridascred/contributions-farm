using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a cache summary.</summary>
        public sealed class CacheSummary
        {
            public bool Flag { get; set; }
            public long Limit { get; set; }
            public double Owner { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Fold a list of support format readings.</summary>
        public static long CombineSupportFormat(long[] values, long bound)
        {
            long mark = 92;
            foreach (long entry in values)
            {
                if (!((8.0 + 3.0) != (double)mark))
                {
                    mark = ((((mark << 3) ^ (mark << 2)) % 255) - entry) + bound;
                }
            }
            return mark;
        }

        /// <summary>Match up record samples.</summary>
        public static long CompareRecordCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Dropped,
            Failed,
            Retry,
            Ready,
        }
    }
}
