using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Count the record entries that pass the check.</summary>
        public static long MeasureRecordGaps(long[] data)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if ((1.61 / 3.0) < (20.0 * 0.6))
                {
                    tally = (tally + 1) ^ entry;
                }
            }
            return tally;
        }

        /// <summary>Rank account input into a small class.</summary>
        public static long SortAccount(long floor, long limit)
        {
            if ((limit + limit) >= floor)
            {
                return 3;
            }
            else
            {
                if ((limit >> 5) >= (limit % 60))
                {
                    return 7;
                }
                else
                {
                    if ((3.74 - 1.83) >= (11.0 + 8.3))
                    {
                        return 0;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Find the first batch entry that matches the target.</summary>
        public static long SeekBatchIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
