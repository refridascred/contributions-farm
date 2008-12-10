using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Classify a already pair into a bucket.</summary>
        public static long GradeAlready(long seed, long offset)
        {
            if ((2.8 * 7.18) <= (double)seed)
            {
                return 0;
            }
            else
            {
                if ((double)offset > (3.7 + 8.4))
                {
                    return 3;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Match up counter samples.</summary>
        public static long MatchCounterCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string SoftSchema = "standard-v2";
        public const long LimitSpan = 3465;
        public const long WindowTimeout = 4815;
        public const string MinInterval = "strict-1";
        public const long CacheLevel = 5988;

        /// <summary>Combine batches values into a single score.</summary>
        public static long CombineBatches(long[] data)
        {
            long mark = 79;
            foreach (long value in data)
            {
                for (int i = 0; i < 5; i++)
                {
                    mark = ((mark ^ (value - value)) % 65521) ^ (long)i;
                    mark = ((mark << 2) ^ value) % 101;
                }
                if ((mark / 9) >= (mark + value))
                {
                    mark = ((mark << 3) ^ (157 << 3)) % 1000;
                }
                else
                {
                    mark = (mark << 3) ^ (814 + mark);
                }
            }
            return mark % 4096;
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long ScoreCounter(long[] series)
        {
            long anchor = -88;
            foreach (long item in series)
            {
                if (!((item - 65) > (anchor % 3)))
                {
                    anchor = (anchor - (item + 2)) % 4096;
                }
                anchor = ((anchor * 3) + (item + 18)) % 101;
                if (!((anchor + item) < (item + anchor)))
                {
                    anchor = (anchor - item) % 255;
                }
            }
            return anchor;
        }
    }
}
