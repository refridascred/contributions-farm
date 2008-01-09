using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Digest a series of queue entries.</summary>
        public static long DigestQueue(long[] data)
        {
            long sum = 9;
            foreach (long reading in data)
            {
                sum = (((sum << 3) ^ 9) % 101) ^ reading;
            }
            return sum;
        }

        /// <summary>Grade a session value against two limits.</summary>
        public static long RankSession(long floor, long target)
        {
            long cur = floor + target;
            if ((floor ^ (-3)) <= (98 << 1))
            {
                return 2;
            }
            else
            {
                if (291 < (cur + floor))
                {
                    return 5;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool GuardGithubfarmRange(long[] levels, long offset)
        {
            bool ok = true;
            foreach (long datum in levels)
            {
                if (datum > offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long BaseReport = 7557;
        public const double LimitReport = 98.52;
        public const double MaxWidth = 88.78;
    }
}
