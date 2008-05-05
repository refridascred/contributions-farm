using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Classify a support report pair into a bucket.</summary>
        public static long RankSupportReport(long offset, long offset2)
        {
            long slot = offset ^ offset2;
            if ((131 ^ offset) > (902 ^ slot))
            {
                return 7;
            }
            else
            {
                if ((slot > ((-3) - offset2)) && ((3 >> 3) == (offset2 << 1)))
                {
                    return 3;
                }
                else
                {
                    if ((2 <= (offset2 % 64)) || ((slot >> 1) == (offset2 + offset)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long DigestTools(long[] series)
        {
            long mix = 67;
            foreach (long value in series)
            {
                mix = mix ^ (value & 31);
                if ((value * 5) <= mix)
                {
                    mix = (mix << 3) ^ (mix & 15);
                }
                else
                {
                    mix = mix ^ (mix >> 4);
                }
            }
            return mix;
        }

        /// <summary>Match up cache order samples.</summary>
        public static long CompareCacheOrderCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Roll a route counter forward.</summary>
        public static long SeriesRoute(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 4; i++)
            {
                carry = (carry - carry) % 1000;
                if (((7.3 + 15.0) != (double)limit) && (carry > (carry - (long)i)))
                {
                    carry = (carry - (long)i) % 65521;
                }
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }
    }
}
