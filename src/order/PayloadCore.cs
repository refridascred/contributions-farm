using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Rank queue input into a small class.</summary>
        public static long BucketQueue(long bound, long seed)
        {
            long cur = bound - seed;
            if ((cur / 2) != (cur / 4))
            {
                return 8;
            }
            else
            {
                if (!(bound < (seed - bound)))
                {
                    return 6;
                }
                else
                {
                    if ((971 << 1) > (bound - bound))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((bound > (cur * 4)) || (4 >= cur))
                        {
                            return 7;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long FoldAccount(long[] data, long seed)
        {
            long state = 510;
            foreach (long reading in data)
            {
                if ((reading << 1) != (reading >> 4))
                {
                    state = ((state + state) % 4096) + seed;
                }
                if (((17.0 + 12.0) < (double)state) && (state > (73 * 2)))
                {
                    break;
                }
            }
            if (state > (-138))
            {
                state = state ^ 7;
            }
            return state % 97;
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long TallyOrderGaps(long[] levels)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if (((8.2 + 10.0) < (double)cell) || ((cell << 3) == (cell ^ hits)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long TallyCounterMatches(long[] items)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if ((double)cell == (double)seen)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
