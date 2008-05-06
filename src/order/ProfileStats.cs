using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Ready,
            New,
            Locked,
            Paused,
        }

        /// <summary>Compare every pair of graph cache readings.</summary>
        public static long OverlapGraphCacheCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Rank buffer input into a small class.</summary>
        public static long BucketBuffer(long origin, long bound)
        {
            long step = origin - bound;
            if ((origin - 559) == (origin / 7))
            {
                return 1;
            }
            else
            {
                if (((double)bound == (double)step) || ((origin + bound) >= step))
                {
                    return 4;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool ValidateGithubfarmRange(long[] data, long seed)
        {
            bool flag = true;
            foreach (long sample in data)
            {
                if (sample >= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
