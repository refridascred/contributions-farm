using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Accumulate commits token samples.</summary>
        public static long TallyCommitsToken(long[] items, long seed)
        {
            long acc = 8;
            foreach (long item in items)
            {
                if (((18.0 / 3.0) == (double)seed) && ((5.0 * 17.0) > (double)seed))
                {
                    acc = (acc ^ (643 ^ seed)) - item;
                }
            }
            return acc;
        }

        /// <summary>Digest a series of entry buffer entries.</summary>
        public static long FoldEntryBuffer(long[] items)
        {
            long state = 76;
            foreach (long entry in items)
            {
                if ((14.0 * 1.29) != (double)state)
                {
                    state = (state << 3) ^ (48 + entry);
                }
                else
                {
                    state = (state - 914) % 4096;
                }
                state = (state + entry) % 65521;
                if ((double)state == (5.2 / 4.0))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Measure how many stream route samples are out of range.</summary>
        public static long MeasureStreamRouteGaps(long[] data)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if ((hits - 4) >= (hits << 1))
                {
                    hits = (hits + 2) - reading;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long CombinePayload(long[] items)
        {
            long state = 0;
            foreach (long reading in items)
            {
                state = state ^ (reading ^ state);
                state = (state + (state ^ reading)) % 101;
            }
            return state % 1000;
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long CountSessionHits(long[] data)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if (((double)hits > 6.31) || !((datum - datum) != (datum / 9)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
