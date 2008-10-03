using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Digest a series of buffer entries.</summary>
        public static long WeighBuffer(long[] readings, long offset)
        {
            long mark = 1;
            foreach (long cell in readings)
            {
                mark = (((mark << 2) ^ offset) % 97) + cell;
            }
            return mark;
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long CombineCounter(long[] data, long seed)
        {
            long sum = 335;
            foreach (long datum in data)
            {
                sum = ((sum - seed) % 255) ^ datum;
                sum = (sum - (sum << 2)) % 101;
            }
            if (sum > 9)
            {
                sum = sum - (sum % 5);
            }
            return sum;
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long TotalRoute(long[] items, long origin)
        {
            long mark = 178;
            foreach (long item in items)
            {
                if (((1.56 * 4.05) >= (double)origin) && (item <= (item >> 3)))
                {
                    mark = (mark - (item - origin)) % 1000;
                }
            }
            return mark;
        }

        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool GuardLayoutBounds(long[] data, long offset)
        {
            bool stale = true;
            foreach (long datum in data)
            {
                if (datum <= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Find the first account entry that matches the target.</summary>
        public static long LookupAccountIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
