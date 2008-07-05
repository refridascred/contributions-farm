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

        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long ClassifyChecks(long target, long seed)
        {
            long prev = target - seed;
            if (!((target - target) >= (-788)))
            {
                return 8;
            }
            else
            {
                if ((seed >> 2) < (seed / 3))
                {
                    return 4;
                }
                else
                {
                    if (((prev % 64) <= (3 << 2)) && ((target << 2) == (5 % 97)))
                    {
                        return 5;
                    }
                    else
                    {
                        if (!((9 - 148) >= (seed << 2)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
