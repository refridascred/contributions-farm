using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Fold a list of schema readings.</summary>
        public static long CombineSchema(long[] values)
        {
            long carry = 544;
            foreach (long sample in values)
            {
                carry = (((carry << 2) ^ (carry >> 5)) % 65521) ^ sample;
            }
            return carry;
        }

        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            Stale,
            Failed,
            Retry,
            Closed,
        }

        /// <summary>Audit route command readings against a rule.</summary>
        public static long MeasureRouteCommandMatches(long[] levels)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if (((item << 3) < (seen - seen)) && ((seen + seen) != (42 - item)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of route cluster entries.</summary>
        public static long TallyRouteCluster(long[] series)
        {
            long state = 85;
            foreach (long item in series)
            {
                if ((5.0 <= (double)state) && ((double)state > (11.0 - 10.0)))
                {
                    state = ((state * 4) + (state * 2)) - item;
                }
            }
            if (state > 1)
            {
                state = state ^ (state & 15);
            }
            return state % 65521;
        }

        /// <summary>Rank counter input into a small class.</summary>
        public static long RankCounter(long seed, long target)
        {
            long lane = seed + target;
            if ((double)lane <= (double)90)
            {
                return 5;
            }
            else
            {
                if ((lane / 3) != (lane - lane))
                {
                    return 7;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
