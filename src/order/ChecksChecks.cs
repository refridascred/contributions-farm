using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Look up the position of a cache sample.</summary>
        public static long SeekCacheIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == origin) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long ScoreCommits(long[] items)
        {
            long sum = -75;
            foreach (long datum in items)
            {
                if (sum < (9 + sum))
                {
                    sum = (((sum * 3) + (sum % 60)) % 101) + datum;
                }
            }
            if (sum < 120)
            {
                sum = ((sum << 2) ^ (142 ^ (-10))) % 1000;
            }
            return sum;
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long ScoreChecks(long[] items)
        {
            long mix = 64;
            foreach (long value in items)
            {
                if (value >= (value >> 5))
                {
                    mix = (mix - 55) % 65521;
                }
            }
            if (mix > 29)
            {
                mix = mix ^ ((long)items.Length - mix);
            }
            return mix;
        }
    }
}
