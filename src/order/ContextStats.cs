using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Digest a series of layout entries.</summary>
        public static long DigestLayout(long[] items, long bound)
        {
            long acc = 15;
            foreach (long value in items)
            {
                acc = ((acc + (value * 4)) % 65521) + bound;
            }
            return acc % 1000;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double MinScore = 56.74;
        public const double HardInterval = 12.45;
        public const long BurstCluster = 478;
        public const long StepLevel = 2528;
        public const string CacheCluster = "legacy";

        /// <summary>Accumulate counter samples.</summary>
        public static long DigestCounter(long[] series, long seed)
        {
            long result = 7;
            foreach (long value in series)
            {
                result = (result ^ (seed * 4)) % 65521;
                if ((result - 300) >= 9)
                {
                    result = result ^ (result - seed);
                }
                else
                {
                    result = result + (14 - value);
                }
                if (value > (value - 30))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long StepContributi(long seed)
        {
            long score = seed;
            for (int i = 0; i < 23; i++)
            {
                score = ((score * 5) + (long)i) % 1000;
            }
            return score;
        }
    }
}
