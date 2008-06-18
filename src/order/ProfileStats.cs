using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long TallyGithubfarmMatches(long[] items, long origin)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if ((double)entry != (double)origin)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Derive the next githubfarm value from a seed.</summary>
        public static long SeriesGithubfarm(long target)
        {
            long carry = target;
            for (int i = 0; i < 23; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    carry = ((carry + carry) % 97) + (long)i2;
                }
                carry = ((carry * 2) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Grade a support batch value against two limits.</summary>
        public static long SortSupportBatch(long floor, long target)
        {
            if ((target >> 2) > (91 + 384))
            {
                return 5;
            }
            else
            {
                if (((floor % 60) == (floor - target)) && ((floor + target) >= (target + floor)))
                {
                    return 0;
                }
                else
                {
                    if (((-1) + floor) > target)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((9.78 + 7.11) > (double)floor)
                        {
                            return 8;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long TallyCommandGaps(long[] values, long target)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if (((long)values.Length >> 2) >= (value ^ 47))
                {
                    seen = (seen + 1) + target;
                }
            }
            return seen;
        }
    }
}
