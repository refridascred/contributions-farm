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

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long SortToken(long seed, long limit)
        {
            if (((seed - seed) <= (seed + 9)) && ((5 - seed) < limit))
            {
                return 1;
            }
            else
            {
                if (((6 - seed) < (seed & 255)) || ((limit << 1) >= (seed + limit)))
                {
                    return 2;
                }
                else
                {
                    if ((double)seed <= (3.93 / 6.0))
                    {
                        return 6;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
