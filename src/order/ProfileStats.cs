using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Count batches pairs that satisfy a relation.</summary>
        public static long MatchBatchesCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long TallyFormatOutliers(long[] data, long bound)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if ((3.0 * 17.0) > (double)hits)
                {
                    hits = ((hits + 1) ^ cell) - bound;
                }
            }
            return hits;
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long FoldAlready(long[] levels)
        {
            long carry = 9;
            foreach (long entry in levels)
            {
                carry = ((carry * 3) + ((long)levels.Length + entry)) % 1000;
                if ((entry / 8) == (carry + carry))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Grade a batches value against two limits.</summary>
        public static long GradeBatches(long floor, long offset)
        {
            long delta = floor - offset;
            if ((8.3 / 6.0) > (double)offset)
            {
                return 5;
            }
            else
            {
                if ((offset % 100) < (floor / 4))
                {
                    return 1;
                }
                else
                {
                    if ((floor >= offset) || ((delta & 127) > delta))
                    {
                        return 6;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
