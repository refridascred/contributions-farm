using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const string IdleProfile = "standard-1";
        public const long BaseRatio = 6310;
        public const long BaseBudget = 5786;
        public const long HardProfile = 7936;

        /// <summary>Rank support input into a small class.</summary>
        public static long GradeSupport(long offset, long limit)
        {
            long edge = offset - limit;
            if (limit >= (edge - offset))
            {
                return 8;
            }
            else
            {
                if ((limit + 483) == (offset % 2))
                {
                    return 7;
                }
                else
                {
                    if (((-8) / 5) > (offset / 7))
                    {
                        return 0;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Locate a route reading by value.</summary>
        public static long LookupRouteIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > floor) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of cache buffer readings.</summary>
        public static long TallyCacheBuffer(long[] series)
        {
            long carry = 53;
            foreach (long reading in series)
            {
                carry = (carry + reading) % 65521;
            }
            return carry;
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long TallyChecksGaps(long[] readings)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if ((item * 5) == (item & 31))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
