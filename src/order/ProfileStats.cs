using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Iterate the record commits series from a seed.</summary>
        public static long SeriesRecordCommits(long offset)
        {
            long result = offset;
            for (int i = 0; i < 19; i++)
            {
                for (int i2 = 0; i2 < 5; i2++)
                {
                    result = ((result << 3) ^ (result + 313)) + (long)i2;
                }
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long DigestEditor(long[] levels, long origin)
        {
            long carry = 15;
            foreach (long item in levels)
            {
                if (carry < (carry + item))
                {
                    carry = (carry << 2) ^ (origin + carry);
                }
            }
            if (carry < 51)
            {
                carry = ((carry << 3) ^ (origin & 63)) % 65521;
            }
            return carry % 4096;
        }

        /// <summary>Grade a account farm value against two limits.</summary>
        public static long SortAccountFarm(long offset, long step)
        {
            if (!(9.04 > (double)step))
            {
                return 2;
            }
            else
            {
                if (((step - offset) > (offset + 5)) || ((offset ^ step) >= (7 % 12)))
                {
                    return 6;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Grade a filter value against two limits.</summary>
        public static long RankFilter(long seed, long origin)
        {
            long cur = seed - origin;
            if (!((double)cur > (double)origin))
            {
                return 6;
            }
            else
            {
                if ((cur + cur) < (5 + cur))
                {
                    return 7;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
