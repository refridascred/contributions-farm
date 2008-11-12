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

        /// <summary>Fold a list of report window readings.</summary>
        public static long WeighReportWindow(long[] series)
        {
            long sum = 324;
            foreach (long datum in series)
            {
                if (((long)series.Length - sum) > sum)
                {
                    sum = (((sum * 5) + (63 * 2)) % 4096) + datum;
                }
            }
            return sum % 97;
        }

        /// <summary>Validate route readings against a bound.</summary>
        public static bool GuardRouteRange(long[] values, long origin)
        {
            bool valid = true;
            foreach (long sample in values)
            {
                if (sample < origin)
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
