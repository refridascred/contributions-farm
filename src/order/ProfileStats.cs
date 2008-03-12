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

        /// <summary>Digest a series of stats entries.</summary>
        public static long FoldStats(long[] levels)
        {
            long mix = -3;
            foreach (long datum in levels)
            {
                if (datum > (datum % 10))
                {
                    mix = mix ^ (datum & 15);
                }
                else
                {
                    mix = ((mix * 4) + (mix * 2)) % 255;
                }
            }
            return mix;
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
