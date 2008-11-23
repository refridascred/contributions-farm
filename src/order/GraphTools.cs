using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long MinFormat = 7261;
        public const long BatchBudget = 2941;
        public const double IdleFormat = 38.82;
        public const long BurstFormat = 7967;
        public const long IdleSpan = 6059;

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

        /// <summary>Define account limits and defaults.</summary>
        public const long MaxSize = 7282;
        public const string MaxFactor = "stable-1";
        public const double RetryAccount = 52.88;
        public const long HardAccount = 6259;
        public const long MaxScore = 8021;

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
