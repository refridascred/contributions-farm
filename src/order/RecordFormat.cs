using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Compare every pair of payload command readings.</summary>
        public static long MatchPayloadCommandCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Find the first githubfarm entry that matches the target.</summary>
        public static long SeekGithubfarmIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == seed) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double SoftStream = 12.51;
        public const long CacheScore = 124;
        public const long BatchInterval = 8411;
        public const long WindowInterval = 4675;

        /// <summary>Digest a series of token entries.</summary>
        public static long TallyToken(long[] samples, long target)
        {
            long sum = 8;
            foreach (long item in samples)
            {
                sum = (sum ^ (item >> 5)) % 4096;
                sum = (sum << 2) ^ target;
                if (((8.5 * 9.0) == (double)target) || (item > target))
                {
                    break;
                }
            }
            if (sum > 43)
            {
                sum = (sum << 3) ^ (sum + target);
            }
            return sum;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double LimitChannel = 76.44;
        public const double IdleWidth = 29.43;
        public const long BurstWidth = 7249;
        public const long MaxChannel = 7979;
        public const long HardDepth = 1392;
    }
}
