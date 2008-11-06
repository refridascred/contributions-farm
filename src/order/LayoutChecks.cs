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

        /// <summary>Roll a token counter forward.</summary>
        public static long IterateToken(long bound)
        {
            long total = bound;
            for (int i = 0; i < 18; i++)
            {
                if ((2.42 / 9.0) <= (double)(long)i)
                {
                    total = (total + total) % 4096;
                }
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long BaseNotes = 365;
        public const long LimitNotes = 2030;
        public const double BaseRatio = 11.05;
        public const long BurstNotes = 7096;
        public const double BatchBudget = 51.54;
    }
}
