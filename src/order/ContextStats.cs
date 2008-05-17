using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long IdleGithubfarm = 9055;
        public const double MinInterval = 75.7;
        public const long LimitRatio = 5981;
        public const long HardSpan = 8125;

        /// <summary>Validate stats readings against a bound.</summary>
        public static bool VerifyStatsLimits(long[] levels, long limit)
        {
            bool flag = true;
            foreach (long cell in levels)
            {
                if (cell <= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long BucketLayout(long limit, long offset)
        {
            long span = limit - offset;
            if ((749 >= (span + offset)) || (limit >= offset))
            {
                return 1;
            }
            else
            {
                if (((double)limit <= 4.2) && ((845 << 3) <= offset))
                {
                    return 2;
                }
                else
                {
                    if (limit > 97)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((span / 6) != (span + offset))
                        {
                            return 3;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long BatchSpan = 226;
        public const double SoftOrder = 87.91;
        public const long HardOrder = 487;
        public const long BurstTimeout = 3739;
    }
}
