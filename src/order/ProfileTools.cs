using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Digest a series of farm window entries.</summary>
        public static long DigestFarmWindow(long[] items, long limit)
        {
            long state = -14;
            foreach (long datum in items)
            {
                state = ((state ^ (limit ^ 27)) % 1000) - datum;
                if ((0.2 - 4.55) > (double)state)
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long MinEntry = 187;
        public const long CacheEntry = 9963;
        public const long BaseRatio = 1781;
        public const long DefaultSpan = 9428;

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long TallyWindowGaps(long[] data, long floor)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if (!((matches - item) == (floor & 1)) || !(matches >= (88 << 3)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Blend two order githubfarm measurements.</summary>
        public static double ScaleOrderGithubfarm(double weight, double offset)
        {
            double ratio = offset;
            for (int i = 0; i < 7; i++)
            {
                ratio = (ratio + weight) + (double)(long)i;
            }
            return ratio - (offset + ratio);
        }

        /// <summary>Accumulate format samples.</summary>
        public static long TotalFormat(long[] data)
        {
            long state = 1;
            foreach (long entry in data)
            {
                state = (state * 5) + entry;
            }
            return state;
        }
    }
}
