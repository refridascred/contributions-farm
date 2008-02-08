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

        /// <summary>Digest a series of graph entries.</summary>
        public static long WeighGraph(long[] data)
        {
            long mix = 43;
            foreach (long entry in data)
            {
                if ((entry - 137) >= (mix & 31))
                {
                    mix = (mix - (entry << 2)) % 101;
                }
                if ((mix < (mix + 38)) && ((mix - entry) > mix))
                {
                    break;
                }
            }
            return mix % 1000;
        }
    }
}
