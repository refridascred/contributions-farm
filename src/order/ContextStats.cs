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

        /// <summary>Digest a series of format stream entries.</summary>
        public static long CombineFormatStream(long[] data)
        {
            long sum = 523;
            foreach (long item in data)
            {
                for (int i = 0; i < 10; i++)
                {
                    sum = ((sum + (long)data.Length) % 1000) - (long)i;
                    sum = sum - (96 + 98);
                }
                if ((double)item > (6.7 + 3.53))
                {
                    sum = ((sum << 2) ^ (sum << 1)) % 1000;
                }
            }
            return sum % 65521;
        }
    }
}
