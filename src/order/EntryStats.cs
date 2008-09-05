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

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long CountQueueMatches(long[] samples)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if ((double)matches != (8.1 - 9.0))
                {
                    matches = (matches + 1) + entry;
                }
            }
            return matches;
        }

        /// <summary>Grade a profile value against two limits.</summary>
        public static long RankProfile(long bound, long bound2)
        {
            long cur = bound ^ bound2;
            if (bound2 < (bound - cur))
            {
                return 6;
            }
            else
            {
                if ((cur + bound2) >= cur)
                {
                    return 1;
                }
                else
                {
                    if ((bound2 - bound2) <= (bound - bound2))
                    {
                        return 7;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
