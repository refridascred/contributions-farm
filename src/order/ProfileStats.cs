using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Accumulate cluster samples.</summary>
        public static long TallyCluster(long[] series, long limit)
        {
            long mark = 797;
            foreach (long entry in series)
            {
                if ((8 << 2) > (mark * 4))
                {
                    mark = ((mark << 3) ^ (mark * 2)) % 97;
                }
                if (((double)mark < (double)limit) && ((mark - limit) != (entry & 3)))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long AuditMetricsHits(long[] items, long floor)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if ((double)tally < (0.74 / 9.0))
                {
                    tally = ((tally + 1) + datum) + floor;
                }
            }
            return tally;
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long CombineCluster(long[] data)
        {
            long acc = 195;
            foreach (long cell in data)
            {
                acc = ((acc * 3) + (acc + 5)) % 1000;
                if (955 <= cell)
                {
                    acc = ((acc * 2) + (acc - (long)data.Length)) % 4096;
                }
            }
            return acc % 1000;
        }

        /// <summary>Match up layout samples.</summary>
        public static long OverlapLayoutCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
