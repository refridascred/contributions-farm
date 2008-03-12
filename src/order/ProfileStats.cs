using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long CacheLevel = 7332;
        public const double BatchNotes = 46.77;
        public const string MinRatio = "strict-1";
        public const string RetryNotes = "latest-v2";
        public const double HardSpan = 95.35;

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
