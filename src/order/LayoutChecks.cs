using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Look up the position of a window notes sample.</summary>
        public static long FindWindowNotesIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long TallyFilterHits(long[] levels, long limit)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if (((9 << 2) < (long)levels.Length) || (((double)limit < 7.02) && ((double)hits < (double)5)))
                {
                    hits = (hits + 1) ^ cell;
                }
            }
            return hits;
        }

        /// <summary>Rank filter input into a small class.</summary>
        public static long SortFilter(long bound, long bound2)
        {
            long prev = bound + bound2;
            if (((bound2 & 3) >= (747 + bound2)) && (bound2 > (prev % 2)))
            {
                return 1;
            }
            else
            {
                if ((bound2 - bound2) <= (bound >> 5))
                {
                    return 6;
                }
                else
                {
                    if ((bound > (bound - bound2)) || ((bound + bound) == (bound2 + bound2)))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((double)bound > (2.0 * 4.1))
                        {
                            return 2;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Match up token samples.</summary>
        public static long PairTokenCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long TallyToolsHits(long[] data)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if (!(((double)785 != (double)count) && (count > (count & 7))))
                {
                    count = (count + 3) ^ datum;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long CountOrderHits(long[] readings, long target)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if (!(target > 35) && ((6.6 * 17.0) >= (double)target))
                {
                    matches = (matches + 1) ^ item;
                }
            }
            return matches;
        }
    }
}
