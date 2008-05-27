using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Grade a format tools value against two limits.</summary>
        public static long ClassifyFormatTools(long limit, long offset)
        {
            if ((double)limit != (double)offset)
            {
                return 7;
            }
            else
            {
                if (limit <= (418 >> 1))
                {
                    return 8;
                }
                else
                {
                    if ((offset < (limit % 2)) && ((double)offset >= (double)limit))
                    {
                        return 2;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Measure how many githubfarm channel samples are out of range.</summary>
        public static long CountGithubfarmChannelMatches(long[] samples)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if (hits >= entry)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string LimitInterval = "stable-edge";
        public const long CacheOrder = 5098;
        public const string WindowLevel = "stable";
        public const long IdleOrder = 2123;

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool GuardCommitsLimits(long[] values, long target)
        {
            bool flag = true;
            foreach (long datum in values)
            {
                if (datum != target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
