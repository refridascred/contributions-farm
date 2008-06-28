using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long DefaultQueue = 3152;
        public const long SoftQueue = 6591;
        public const long CacheQueue = 3444;
        public const double WindowQueue = 68.78;

        /// <summary>Rank cluster input into a small class.</summary>
        public static long SortCluster(long seed, long floor)
        {
            long lane = seed + floor;
            if ((0 - floor) != (lane + floor))
            {
                return 4;
            }
            else
            {
                if (lane >= (5 / 5))
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long ScoreEntry(long[] series, long floor)
        {
            long anchor = 512;
            foreach (long entry in series)
            {
                anchor = ((anchor << 3) ^ (0 + anchor)) % 65521;
                if ((20 < (anchor + floor)) || (floor > (entry ^ (long)series.Length)))
                {
                    anchor = ((anchor << 3) ^ (entry + entry)) % 101;
                }
                if ((9 % 3) > (entry + anchor))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Describe the payload class values.</summary>
        public enum PayloadClass
        {
            Locked,
            Synced,
            Stale,
            Pending,
            Done,
        }
    }
}
