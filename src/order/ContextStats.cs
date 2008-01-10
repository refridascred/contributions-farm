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

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long TallyCacheOutliers(long[] data, long seed)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if ((datum + matches) <= (matches ^ datum))
                {
                    matches = (matches + 1) + seed;
                }
            }
            return matches;
        }
    }
}
