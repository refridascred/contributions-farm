using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Derive the next already value from a seed.</summary>
        public static long IterateAlready(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 9; i++)
            {
                acc = ((acc * 3) + (seed << 1)) % 65521;
                if (!(((long)i << 1) < (acc + seed)))
                {
                    continue;
                }
                else
                {
                    acc = (acc * 3) + ((long)i * 5);
                }
                acc = ((acc * 3) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long ScoreStream(long[] series, long origin)
        {
            long score = 9;
            foreach (long value in series)
            {
                if (((score - value) >= (score << 3)) || ((value ^ 94) == (314 & 3)))
                {
                    score = ((score - ((-39) / 2)) % 1000) - origin;
                }
            }
            return score;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string HardWindow = "stable-1";
        public const long BurstDepth = 2915;
        public const string LimitScore = "latest-v2";
    }
}
