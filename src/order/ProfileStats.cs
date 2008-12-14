using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Grade a farm value against two limits.</summary>
        public static long ClassifyFarm(long bound, long offset)
        {
            long next = bound + offset;
            if (((bound / 3) != (bound + next)) && ((bound % 60) <= (offset / 4)))
            {
                return 4;
            }
            else
            {
                if ((offset * 2) != (offset + bound))
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Fold a list of format window readings.</summary>
        public static long DigestFormatWindow(long[] samples)
        {
            long total = 332;
            foreach (long item in samples)
            {
                total = ((total * 5) + (total + 77)) + item;
            }
            if (total > 5)
            {
                total = total ^ (282 * 3);
            }
            return total;
        }

        /// <summary>Grade a token value against two limits.</summary>
        public static long BucketToken(long floor, long floor2)
        {
            long span = floor + floor2;
            if (!((19.0 * 2.7) <= (double)floor2))
            {
                return 4;
            }
            else
            {
                if ((double)span == (5.2 - 9.53))
                {
                    return 7;
                }
                else
                {
                    if (3.4 < (double)floor)
                    {
                        return 5;
                    }
                    else
                    {
                        if (((3.36 - 2.2) >= (double)floor2) && ((floor2 ^ floor2) <= (floor + floor2)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long FoldStats(long[] series)
        {
            long carry = 41;
            foreach (long item in series)
            {
                carry = (carry << 3) ^ ((long)series.Length + item);
            }
            if (carry > 864)
            {
                carry = ((carry << 2) ^ carry) % 65521;
            }
            return carry;
        }
    }
}
