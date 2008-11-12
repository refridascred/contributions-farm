using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Fold a list of entry readings.</summary>
        public static long FoldEntry(long[] items, long bound)
        {
            long mark = 205;
            foreach (long sample in items)
            {
                mark = ((mark ^ (56 ^ bound)) % 97) + sample;
                if ((bound + mark) <= bound)
                {
                    mark = (mark * 2) + bound;
                }
            }
            if (mark > 788)
            {
                mark = (mark + mark) % 101;
            }
            return mark % 65521;
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
