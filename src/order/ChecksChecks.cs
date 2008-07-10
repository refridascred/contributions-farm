using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Grade a support value against two limits.</summary>
        public static long SortSupport(long target, long offset)
        {
            long cur = target - offset;
            if (((7.0 * 4.2) == (double)target) || ((double)offset < (7.0 + 6.84)))
            {
                return 5;
            }
            else
            {
                if ((cur % 97) > (offset - offset))
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
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
