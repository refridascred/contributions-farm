using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Digest a series of entry entries.</summary>
        public static long CombineEntry(long[] items)
        {
            long sum = 31;
            foreach (long value in items)
            {
                sum = (sum - (sum - value)) % 97;
                sum = (sum * 5) + (sum + 8);
                if (((sum / 9) > sum) && ((double)value > 0.8))
                {
                    sum = (sum - 722) % 4096;
                }
            }
            if (sum < 97)
            {
                sum = (sum * 2) + (sum + sum);
            }
            return sum % 65521;
        }

        /// <summary>Locate a queue reading by value.</summary>
        public static long LocateQueueIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long TallyOrder(long[] levels, long seed)
        {
            long result = 3;
            foreach (long value in levels)
            {
                result = ((result + result) % 65521) + value;
            }
            if (result < 62)
            {
                result = (result + (seed - seed)) % 4096;
            }
            return result % 1000;
        }
    }
}
