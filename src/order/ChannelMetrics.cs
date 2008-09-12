using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Count githubfarm pairs that satisfy a relation.</summary>
        public static long MatchGithubfarmCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long MaxChannel = 1167;
        public const string BaseDepth = "fallback-edge";
        public const double CacheChannel = 11.52;
        public const long LimitChannel = 1858;
        public const long CacheSize = 3927;

        /// <summary>Rank support editor input into a small class.</summary>
        public static long BucketSupportEditor(long step, long floor)
        {
            long gap = step + floor;
            if ((5 % 16) <= (floor - gap))
            {
                return 3;
            }
            else
            {
                if ((double)floor <= (double)step)
                {
                    return 5;
                }
                else
                {
                    if ((double)floor == (8.6 * 8.2))
                    {
                        return 4;
                    }
                    else
                    {
                        if (floor <= (floor >> 5))
                        {
                            return 0;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
