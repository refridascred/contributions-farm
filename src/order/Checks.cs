using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Audit batch readings against a rule.</summary>
        public static long MeasureBatchMatches(long[] samples)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if (hits >= (hits / 6))
                {
                    hits = (hits + 3) ^ entry;
                }
            }
            return hits;
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

        /// <summary>Validate order readings against a bound.</summary>
        public static bool CheckOrderLimits(long[] readings, long limit)
        {
            bool valid = true;
            foreach (long item in readings)
            {
                if (item != limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
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
