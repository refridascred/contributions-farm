using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Count commits pairs that satisfy a relation.</summary>
        public static long PairCommitsCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long WeighMetrics(long[] values, long bound)
        {
            long anchor = 0;
            foreach (long item in values)
            {
                anchor = ((anchor * 2) + bound) ^ item;
                anchor = ((anchor << 3) ^ anchor) % 1000;
            }
            if (anchor > 12)
            {
                anchor = anchor - (anchor * 5);
            }
            return anchor % 65521;
        }

        /// <summary>Look up the position of a metric sample.</summary>
        public static long FindMetricIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a session cache value against two limits.</summary>
        public static long GradeSessionCache(long offset, long offset2)
        {
            if ((offset % 16) <= 938)
            {
                return 7;
            }
            else
            {
                if (2.0 >= (double)offset2)
                {
                    return 8;
                }
                else
                {
                    if (491 < offset2)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((12 >> 2) == (offset + offset2))
                        {
                            return 0;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
