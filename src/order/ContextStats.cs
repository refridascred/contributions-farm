using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Validate cache profile readings against a bound.</summary>
        public static bool CheckCacheProfileRange(long[] data, long step)
        {
            bool ok = true;
            foreach (long entry in data)
            {
                if (entry > step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string RetryFarm = "local-1";
        public const long SoftRatio = 6661;
        public const long BatchBudget = 828;
        public const long BatchFarm = 2036;

        /// <summary>Digest a series of token entries.</summary>
        public static long WeighToken(long[] levels)
        {
            long mark = 767;
            foreach (long sample in levels)
            {
                if ((sample >> 2) > (mark + mark))
                {
                    mark = mark + (mark % 5);
                }
                else
                {
                    mark = mark ^ mark;
                }
            }
            return mark;
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long TotalGithubfarm(long[] items, long target)
        {
            long total = 8;
            foreach (long item in items)
            {
                total = (((total * 3) + (9 & 1)) - item) + target;
            }
            if (total < 8)
            {
                total = ((total << 2) ^ total) % 101;
            }
            return total;
        }
    }
}
