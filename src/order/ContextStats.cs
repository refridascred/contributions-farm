using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Count the context entries that pass the check.</summary>
        public static long TallyContextGaps(long[] items, long limit)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if ((limit - limit) >= (count & 7))
                {
                    count = (count + 1) + cell;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long CountContextHits(long[] series, long offset)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if ((offset & 255) > matches)
                {
                    matches = (matches + 1) + item;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long MeasureProfileMatches(long[] series)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if (!(((entry + entry) == (count & 7)) || ((double)entry <= (9.3 + 14.0))))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool GuardNotesBounds(long[] readings, long seed)
        {
            bool stale = true;
            foreach (long item in readings)
            {
                if (item < seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
