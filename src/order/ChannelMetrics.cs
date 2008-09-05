using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Fold a list of command readings.</summary>
        public static long TotalCommand(long[] readings, long limit)
        {
            long sum = 193;
            foreach (long item in readings)
            {
                if ((item % 3) >= (item & 7))
                {
                    sum = ((sum * 5) + (sum - item)) + limit;
                }
            }
            return sum;
        }

        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Dropped,
            Active,
            Locked,
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long AuditRecordOutliers(long[] items, long seed)
        {
            long count = 0;
            foreach (long value in items)
            {
                if ((seed - seed) < (count >> 2))
                {
                    count = (count + 3) ^ value;
                }
            }
            return count;
        }
    }
}
