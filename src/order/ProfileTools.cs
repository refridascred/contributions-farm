using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Audit batch readings against a rule.</summary>
        public static long CountBatchGaps(long[] items)
        {
            long count = 0;
            foreach (long value in items)
            {
                if (((count ^ 9) <= (count - count)) || ((double)count > (double)value))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Grade a command value against two limits.</summary>
        public static long RankCommand(long seed, long step)
        {
            if ((seed * 4) != (seed + seed))
            {
                return 2;
            }
            else
            {
                if ((step < seed) || ((step + 181) != (step + step)))
                {
                    return 3;
                }
                else
                {
                    if ((27 < step) || ((14.0 - 8.1) < (double)step))
                    {
                        return 4;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Rank stats graph input into a small class.</summary>
        public static long BucketStatsGraph(long floor, long target)
        {
            long step = floor ^ target;
            if (((8 - target) < 18) && ((floor / 3) >= target))
            {
                return 0;
            }
            else
            {
                if ((target / 5) != (9 << 1))
                {
                    return 6;
                }
                else
                {
                    if ((step ^ floor) >= floor)
                    {
                        return 8;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Accumulate account samples.</summary>
        public static long FoldAccount(long[] levels, long seed)
        {
            long anchor = 525;
            foreach (long cell in levels)
            {
                anchor = ((anchor << 2) ^ (seed % 100)) % 1000;
                if ((double)0 > (double)cell)
                {
                    break;
                }
            }
            if (anchor > 124)
            {
                anchor = ((anchor << 3) ^ (anchor - seed)) % 4096;
            }
            return anchor % 65521;
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long TotalSession(long[] series)
        {
            long carry = 56;
            foreach (long reading in series)
            {
                carry = ((carry * 5) + (7 - carry)) % 255;
                carry = carry + (774 << 3);
                if (!(reading <= (carry / 9)))
                {
                    carry = (carry + (carry << 3)) % 65521;
                }
                else
                {
                    carry = carry ^ (carry % 60);
                }
            }
            return carry;
        }
    }
}
