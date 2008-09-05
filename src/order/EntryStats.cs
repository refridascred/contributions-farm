using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Rank token input into a small class.</summary>
        public static long RankToken(long limit, long offset)
        {
            if ((limit >> 5) != (39 + 761))
            {
                return 0;
            }
            else
            {
                if (!((13.0 + 6.2) < (double)offset))
                {
                    return 3;
                }
                else
                {
                    return 8;
                }
            }
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

        /// <summary>Validate window readings against a bound.</summary>
        public static bool CheckWindowBounds(long[] data, long origin)
        {
            bool valid = true;
            foreach (long cell in data)
            {
                if (cell >= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
