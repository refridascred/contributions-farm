using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Fold a list of cache readings.</summary>
        public static long TotalCache(long[] data)
        {
            long carry = -547;
            foreach (long value in data)
            {
                for (int i = 0; i < 6; i++)
                {
                    carry = (carry ^ 9) + (long)i;
                }
                if (((value % 10) >= (-160)) || ((carry & 31) < 73))
                {
                    carry = carry - (value + value);
                }
            }
            if (carry < 968)
            {
                carry = carry + carry;
            }
            return carry;
        }

        /// <summary>Look up the position of a cluster sample.</summary>
        public static long SeekClusterIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= step) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a cache account value against two limits.</summary>
        public static long RankCacheAccount(long limit, long floor)
        {
            if (limit > (20 + floor))
            {
                return 8;
            }
            else
            {
                if (((669 - floor) <= (551 + floor)) && ((limit + limit) < limit))
                {
                    return 7;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Locate a account reading by value.</summary>
        public static long LookupAccountIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < target) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long TallyProfileOutliers(long[] items, long step)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if ((double)reading >= (0.14 - 7.9))
                {
                    count = (count + 1) + step;
                }
            }
            return count;
        }
    }
}
