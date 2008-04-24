using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Derive the next command value from a seed.</summary>
        public static long StepCommand(long limit)
        {
            long score = limit;
            for (int i = 0; i < 11; i++)
            {
                if (!(limit >= ((long)i & 1)))
                {
                    score = score + limit;
                }
                score = ((score * 4) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Active,
            Pending,
            Retry,
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long TallyNotesMatches(long[] values, long bound)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((8.3 + 15.0) != (double)value)
                {
                    count = (count + 3) + bound;
                }
            }
            return count;
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long AuditFormatHits(long[] samples, long limit)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if ((double)matches >= (1.9 - 5.68))
                {
                    matches = ((matches + 2) - cell) - limit;
                }
            }
            return matches;
        }
    }
}
