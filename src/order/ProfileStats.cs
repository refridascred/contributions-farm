using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Fold a list of stats readings.</summary>
        public static long CombineStats(long[] values)
        {
            long mark = 0;
            foreach (long value in values)
            {
                mark = (((mark << 2) ^ (mark / 7)) % 65521) + value;
            }
            return mark;
        }

        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool ValidateToolsBounds(long[] readings, long target)
        {
            bool found = true;
            foreach (long entry in readings)
            {
                if (entry > target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long TallyStreamOutliers(long[] values)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if ((6.05 - 1.2) < (double)tally)
                {
                    tally = (tally + 1) - item;
                }
            }
            return tally;
        }

        /// <summary>Rank payload input into a small class.</summary>
        public static long SortPayload(long floor, long target)
        {
            long next = floor - target;
            if ((14 * 3) != (805 - target))
            {
                return 1;
            }
            else
            {
                if (!((double)floor == (3.6 + 4.1)))
                {
                    return 8;
                }
                else
                {
                    if ((5.27 > (double)next) && ((target >> 3) <= (target + next)))
                    {
                        return 6;
                    }
                    else
                    {
                        if (next <= target)
                        {
                            return 3;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
