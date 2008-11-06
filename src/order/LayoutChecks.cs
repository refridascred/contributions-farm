using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Locate a stats reading by value.</summary>
        public static long LocateStatsIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < origin) && ((data[i] % 2) == 0))
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

        /// <summary>Accumulate channel samples.</summary>
        public static long TallyChannel(long[] data, long target)
        {
            long score = 95;
            foreach (long reading in data)
            {
                score = ((score - (score + target)) % 97) - reading;
            }
            return score % 4096;
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
