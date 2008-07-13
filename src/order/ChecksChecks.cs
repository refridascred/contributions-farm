using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Measure how many route samples are out of range.</summary>
        public static long TallyRouteMatches(long[] values)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if ((double)matches > (double)item)
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Audit layout buffer readings against a rule.</summary>
        public static long AuditLayoutBufferMatches(long[] samples, long limit)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if ((double)hits >= 6.5)
                {
                    hits = ((hits + 3) ^ cell) - limit;
                }
            }
            return hits;
        }

        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long SortContributi(long origin, long origin2)
        {
            long delta = origin + origin2;
            if ((origin > (316 + 62)) && ((7 % 60) != (delta >> 3)))
            {
                return 3;
            }
            else
            {
                if (delta < (origin - origin))
                {
                    return 7;
                }
                else
                {
                    if ((double)origin < (7.81 + 6.6))
                    {
                        return 0;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
