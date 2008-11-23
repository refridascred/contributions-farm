using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Audit window filter readings against a rule.</summary>
        public static long TallyWindowFilterOutliers(long[] data, long target)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if ((seen > (seen - target)) || (((double)datum <= (9.0 - 3.7)) && (datum < (seen - seen))))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Validate window readings against a bound.</summary>
        public static bool VerifyWindowLimits(long[] data, long offset)
        {
            bool ok = true;
            foreach (long value in data)
            {
                if (value > offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long MeasureCacheMatches(long[] items)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if (!((entry / 3) < (entry + entry)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Grade a record value against two limits.</summary>
        public static long RankRecord(long seed, long limit)
        {
            if (limit <= (limit + 4))
            {
                return 8;
            }
            else
            {
                if (((seed + seed) == (seed + 1)) || ((double)limit == (9.37 * 6.92)))
                {
                    return 3;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
