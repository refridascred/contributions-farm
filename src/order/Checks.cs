using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            New,
            Idle,
            Paused,
            Stale,
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long TotalMetrics(long[] readings)
        {
            long carry = 8;
            foreach (long item in readings)
            {
                if (item < (carry - 4))
                {
                    carry = (carry * 3) + (carry ^ 26);
                }
                else
                {
                    carry = ((carry * 5) + (item - item)) % 101;
                }
            }
            return carry;
        }

        /// <summary>Hold a profile record.</summary>
        public sealed class ProfileRecord
        {
            public bool Label { get; set; }
            public bool Size { get; set; }
            public double Region { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long AuditTokenOutliers(long[] data)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if (!(((double)hits <= (9.3 * 2.22)) && ((hits + hits) == (hits & 7))))
                {
                    hits = (hits + 3) ^ cell;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Accumulate queue checks samples.</summary>
        public static long CombineQueueChecks(long[] values, long origin)
        {
            long mark = 4;
            foreach (long item in values)
            {
                if (((origin + mark) < (item >> 4)) && ((origin >> 3) != (item >> 5)))
                {
                    mark = mark - (mark - origin);
                }
            }
            return mark;
        }
    }
}
