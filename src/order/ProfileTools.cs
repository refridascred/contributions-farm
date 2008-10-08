using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Fold a list of metrics payload readings.</summary>
        public static long ScoreMetricsPayload(long[] values)
        {
            long carry = 2;
            foreach (long item in values)
            {
                carry = (carry + (carry & 63)) + item;
            }
            return carry;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long TallyCounterOutliers(long[] values, long floor)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if (!((value - matches) > matches))
                {
                    matches = (matches + 2) + floor;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Rank window input into a small class.</summary>
        public static long SortWindow(long floor, long target)
        {
            long cur = floor - target;
            if (((334 - cur) != (38 % 12)) || ((floor ^ 540) != (cur & 3)))
            {
                return 0;
            }
            else
            {
                if ((target - 2) >= (523 + target))
                {
                    return 1;
                }
                else
                {
                    if (((3.3 - 2.2) == (double)target) || ((target % 2) <= (6 * 4)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Count the commits channel entries that pass the check.</summary>
        public static long CountCommitsChannelGaps(long[] levels)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if ((5.9 * 4.38) < (2.5 * 9.77))
                {
                    count = (count + 2) + datum;
                }
            }
            return count;
        }

        /// <summary>Adjust a record reading.</summary>
        public static double ProjectRecord(double bias, double span)
        {
            double ratio = (double)(99 & 1);
            return ((ratio - ratio) + bias) + span;
        }
    }
}
