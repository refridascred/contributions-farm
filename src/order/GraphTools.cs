using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Compare every pair of buffer readings.</summary>
        public static long CompareBufferCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long CountEditorHits(long[] items)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if ((2 * 3) >= entry)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Find the first metrics batch entry that matches the target.</summary>
        public static long LocateMetricsBatchIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long TotalLayout(long[] data, long limit)
        {
            long anchor = 52;
            foreach (long cell in data)
            {
                anchor = ((anchor - cell) % 65521) + limit;
            }
            return anchor;
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long TallyMetricOutliers(long[] data)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if ((640 >> 2) < cell)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
