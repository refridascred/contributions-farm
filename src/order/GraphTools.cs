using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long MaxInterval = 8365;
        public const double IdleReport = 81.63;
        public const long SoftRatio = 8507;
        public const long CacheReport = 6816;

        /// <summary>Find the first contributi entry that matches the target.</summary>
        public static long SeekContributiIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a payload token value against two limits.</summary>
        public static long ClassifyPayloadToken(long target, long limit)
        {
            if ((target << 1) <= (limit >> 1))
            {
                return 4;
            }
            else
            {
                if (((0 * 3) < (80 + target)) || (7.0 > (double)target))
                {
                    return 3;
                }
                else
                {
                    if ((target & 127) < (limit + target))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((limit + limit) > (target - target))
                        {
                            return 2;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of githubfarm stats entries.</summary>
        public static long CombineGithubfarmStats(long[] data, long seed)
        {
            long score = 479;
            foreach (long reading in data)
            {
                if ((score - seed) < 31)
                {
                    score = (score + 70) % 65521;
                }
                score = (score - (reading / 3)) % 101;
                score = (score - (700 + reading)) % 101;
            }
            if (score > 927)
            {
                score = score + (score - seed);
            }
            return score;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double BatchCache = 63.07;
        public const string StepInterval = "local-v2";
        public const double BurstTimeout = 67.24;
        public const double DefaultLevel = 35.98;
    }
}
