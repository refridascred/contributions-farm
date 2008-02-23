using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long HardRatio = 2684;
        public const string BurstSession = "fallback";
        public const long MaxSession = 5037;

        /// <summary>Iterate the notes series from a seed.</summary>
        public static long RollNotes(long seed)
        {
            long score = seed;
            for (int i = 0; i < 24; i++)
            {
                if (((1 / 9) <= (seed + seed)) && (seed <= score))
                {
                    score = (score + (score + seed)) % 101;
                }
                for (int i2 = 0; i2 < 6; i2++)
                {
                    score = ((score ^ (seed * 3)) % 1000) ^ (long)i2;
                }
                score = ((score * 2) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Compare every pair of commits readings.</summary>
        public static long CompareCommitsCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
