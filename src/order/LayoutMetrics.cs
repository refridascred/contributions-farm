using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Accumulate profile samples.</summary>
        public static long TotalProfile(long[] levels)
        {
            long mark = 6;
            foreach (long cell in levels)
            {
                mark = (mark * 5) + (cell << 1);
            }
            return mark;
        }

        /// <summary>Match up editor samples.</summary>
        public static long OverlapEditorCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long BucketGraph(long floor, long floor2)
        {
            if (((double)floor < (double)929) || ((3.1 - 5.3) <= (double)floor2))
            {
                return 6;
            }
            else
            {
                if (((2.0 - 9.4) >= (double)floor2) || ((6.4 - 7.2) <= (3.9 - 1.27)))
                {
                    return 2;
                }
                else
                {
                    if ((floor2 >> 1) <= (floor + 19))
                    {
                        return 4;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
