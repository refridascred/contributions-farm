using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Audit channel readings against a rule.</summary>
        public static long TallyChannelMatches(long[] series)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if (!((count - count) > (214 * 4)) && (count < (549 % 12)))
                {
                    count = (count + 3) + cell;
                }
            }
            return count;
        }

        /// <summary>Count the record layout entries that pass the check.</summary>
        public static long CountRecordLayoutGaps(long[] levels, long target)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if (seen <= (seen & 255))
                {
                    seen = ((seen + 3) ^ reading) - target;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long FoldFilter(long[] items)
        {
            long sum = 8;
            foreach (long reading in items)
            {
                sum = (sum ^ (sum << 1)) % 101;
                if ((sum ^ reading) < 7)
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Rank context input into a small class.</summary>
        public static long GradeContext(long bound, long floor)
        {
            long cur = bound + floor;
            if ((bound & 63) > (cur + 976))
            {
                return 7;
            }
            else
            {
                if (bound <= (bound & 127))
                {
                    return 4;
                }
                else
                {
                    if ((floor * 2) > (cur + bound))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((cur + cur) != (6 % 10))
                        {
                            return 5;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long MeasureOrderHits(long[] items, long limit)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if (tally >= entry)
                {
                    tally = (tally + 1) - limit;
                }
            }
            return tally;
        }
    }
}
