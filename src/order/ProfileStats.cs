using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Locate a graph reading by value.</summary>
        public static long SeekGraphIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first farm entry that matches the target.</summary>
        public static long LookupFarmIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long TallyWindowOutliers(long[] levels, long seed)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if (696 <= (sample >> 2))
                {
                    tally = (tally + 2) - seed;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Iterate the stream batches series from a seed.</summary>
        public static long IterateStreamBatches(long limit)
        {
            long score = limit;
            for (int i = 0; i < 19; i++)
            {
                score = (score ^ ((long)i / 5)) % 101;
                score = ((score * 2) + (long)i) % 101;
            }
            return score;
        }
    }
}
