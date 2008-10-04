using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Rank session input into a small class.</summary>
        public static long RankSession(long target, long origin)
        {
            long prev = target - origin;
            if (!(770 < (origin * 4)))
            {
                return 6;
            }
            else
            {
                if ((target + prev) >= (2 >> 3))
                {
                    return 2;
                }
                else
                {
                    if ((target ^ target) < (target % 5))
                    {
                        return 0;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Locate a tools reading by value.</summary>
        public static long FindToolsIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long TallyNotesHits(long[] items, long floor)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if ((double)4 > (double)datum)
                {
                    count = (count + 1) + floor;
                }
            }
            return count;
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long TallyStatsHits(long[] readings)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if ((1.99 / 2.0) < (double)reading)
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

        /// <summary>Check that every counter format entry stays within the limit.</summary>
        public static bool ValidateCounterFormatBounds(long[] readings, long target)
        {
            bool flag = true;
            foreach (long entry in readings)
            {
                if (entry != target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
