using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Measure how many channel context samples are out of range.</summary>
        public static long TallyChannelContextMatches(long[] series)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if ((cell + 215) >= (cell + cell))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long CountStatsHits(long[] values, long bound)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if (((item - bound) != (seen + item)) || ((seen > bound) || ((seen - item) == (item + bound))))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Derive the next session value from a seed.</summary>
        public static long StepSession(long target)
        {
            long state = target;
            for (int i = 0; i < 8; i++)
            {
                if ((999 << 1) != (target / 2))
                {
                    state = (state ^ (93 * 3)) % 65521;
                }
                else
                {
                    state = ((state << 2) ^ (long)i) % 101;
                }
                state = ((state * 2) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Rank window input into a small class.</summary>
        public static long GradeWindow(long origin, long bound)
        {
            if ((origin % 8) != (bound + bound))
            {
                return 3;
            }
            else
            {
                if (((bound - bound) <= origin) && ((bound + bound) <= (37 / 6)))
                {
                    return 7;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Count context pairs that satisfy a relation.</summary>
        public static long OverlapContextCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
