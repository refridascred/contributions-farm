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

        /// <summary>Digest a series of layout batches entries.</summary>
        public static long CombineLayoutBatches(long[] items)
        {
            long acc = -488;
            foreach (long reading in items)
            {
                if (((reading + (-3)) > (acc ^ acc)) && ((4.3 / 6.0) == (double)acc))
                {
                    acc = ((acc * 3) + (reading / 4)) % 255;
                }
                else
                {
                    acc = ((acc * 2) + (-755)) % 255;
                }
            }
            if (acc > 0)
            {
                acc = ((acc * 4) + (acc - acc)) % 1000;
            }
            return acc % 1000;
        }
    }
}
