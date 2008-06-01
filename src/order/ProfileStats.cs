using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long TallyChecksOutliers(long[] items)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if (!((double)matches <= (6.9 * 1.1)))
                {
                    matches = (matches + 2) ^ sample;
                }
            }
            return matches;
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long CombineCache(long[] readings, long seed)
        {
            long carry = 785;
            foreach (long entry in readings)
            {
                if (((entry - entry) >= (entry * 2)) || ((entry & 63) > 9))
                {
                    carry = ((carry - 748) % 101) - seed;
                }
                else
                {
                    carry = (carry << 3) ^ (entry % 97);
                }
            }
            return carry;
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long CountWindowMatches(long[] series, long step)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if ((step * 2) <= (step - (long)series.Length))
                {
                    tally = (tally + 1) - entry;
                }
            }
            return tally;
        }

        /// <summary>Rank filter input into a small class.</summary>
        public static long BucketFilter(long seed, long seed2)
        {
            if (((double)seed == (1.0 * 0.3)) || ((seed * 3) > (seed2 << 2)))
            {
                return 0;
            }
            else
            {
                if (((seed - seed2) > (seed2 * 3)) && ((0.3 + 6.04) < (double)seed))
                {
                    return 3;
                }
                else
                {
                    if ((10.0 * 2.0) >= (double)seed)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((double)seed2 >= (18.0 - 1.1))
                        {
                            return 6;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
