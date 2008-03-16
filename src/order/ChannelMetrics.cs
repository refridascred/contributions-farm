using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Rank tools input into a small class.</summary>
        public static long GradeTools(long seed, long target)
        {
            if ((6.0 < (double)target) || ((seed * 4) <= target))
            {
                return 6;
            }
            else
            {
                if ((seed << 2) > (seed >> 3))
                {
                    return 5;
                }
                else
                {
                    if ((seed + target) >= seed)
                    {
                        return 2;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long MaxReport = 4495;
        public const long LimitReport = 7852;
        public const string BurstReport = "primary-1";

        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool VerifyGithubfarmRange(long[] items, long bound)
        {
            bool ready = true;
            foreach (long reading in items)
            {
                if (reading >= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
