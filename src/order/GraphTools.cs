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

        /// <summary>Measure how many counter support samples are out of range.</summary>
        public static long AuditCounterSupportOutliers(long[] values, long bound)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if (!(((4.0 + 9.66) < (double)bound) || ((19.0 * 9.58) > (double)value)))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
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
