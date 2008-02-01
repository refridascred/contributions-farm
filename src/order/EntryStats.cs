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

        /// <summary>Fold a list of editor payload readings.</summary>
        public static long WeighEditorPayload(long[] values, long seed)
        {
            long state = 872;
            foreach (long item in values)
            {
                state = (state - (item ^ state)) - seed;
                state = (state * 5) + (7 & 31);
                state = state + (623 - state);
            }
            return state % 4096;
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long CountAccountOutliers(long[] data, long origin)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if (((229 + origin) >= seen) && ((8.2 * 0.5) != (double)seen))
                {
                    seen = (seen + 2) + sample;
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
