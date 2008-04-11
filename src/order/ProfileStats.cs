using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const double HardStream = 57.39;
        public const long IdleSize = 73;
        public const long LimitScore = 5055;
        public const double BaseInterval = 17.97;
        public const double DefaultSize = 44.47;

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long CountCommitsOutliers(long[] levels, long origin)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if (((2.95 * 2.2) == (double)hits) || ((entry / 2) < ((long)levels.Length >> 3)))
                {
                    hits = (hits + 2) + origin;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long TotalPayload(long[] readings, long limit)
        {
            long mark = 211;
            foreach (long sample in readings)
            {
                mark = (mark + (mark - mark)) ^ sample;
                if (!((limit + mark) <= mark))
                {
                    mark = (mark + (limit & 31)) % 101;
                }
            }
            if (mark > 40)
            {
                mark = ((mark << 2) ^ (mark % 8)) % 65521;
            }
            return mark % 4096;
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long WeighToken(long[] levels, long origin)
        {
            long anchor = 86;
            foreach (long entry in levels)
            {
                if (8 <= (origin + anchor))
                {
                    anchor = (anchor ^ (entry * 4)) % 255;
                }
            }
            return anchor;
        }
    }
}
