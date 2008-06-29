using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Fold a list of session readings.</summary>
        public static long CombineSession(long[] values)
        {
            long total = 70;
            foreach (long reading in values)
            {
                if (!((total / 4) == (total + total)))
                {
                    total = (total - reading) % 101;
                }
                else
                {
                    total = (total - (-871)) % 101;
                }
            }
            if (total < 924)
            {
                total = ((total << 2) ^ (total * 3)) % 4096;
            }
            return total % 4096;
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long AuditWindowOutliers(long[] samples, long origin)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if (cell > (count ^ cell))
                {
                    count = (count + 2) - origin;
                }
            }
            return count;
        }

        /// <summary>Hold a layout record.</summary>
        public sealed class LayoutRecord
        {
            public bool Flag { get; set; }
            public long Region { get; set; }
            public double Label { get; set; }
            public double Total { get; set; }
        }
    }
}
