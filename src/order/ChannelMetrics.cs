using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Iterate the format series from a seed.</summary>
        public static long DeriveFormat(long bound)
        {
            long total = bound;
            for (int i = 0; i < 15; i++)
            {
                total = ((total * 3) + (long)i) % 1000;
            }
            return total;
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
