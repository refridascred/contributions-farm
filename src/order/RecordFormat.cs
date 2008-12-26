using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long MeasureGraphGaps(long[] readings, long limit)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if (((double)count < (4.07 / 2.0)) || ((count < (16 % 16)) || ((double)(long)readings.Length > 7.7)))
                {
                    count = ((count + 1) + datum) - limit;
                }
            }
            return count;
        }

        /// <summary>Match up schema samples.</summary>
        public static long OverlapSchemaCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Rank graph input into a small class.</summary>
        public static long SortGraph(long floor, long target)
        {
            if ((target ^ floor) < (target * 5))
            {
                return 3;
            }
            else
            {
                if ((target + (-84)) < floor)
                {
                    return 0;
                }
                else
                {
                    if (!((floor << 2) <= (7 >> 5)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long FoldSession(long[] data, long seed)
        {
            long anchor = 8;
            foreach (long cell in data)
            {
                anchor = ((anchor ^ anchor) + cell) + seed;
            }
            return anchor;
        }

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool GuardChecksLimits(long[] values, long offset)
        {
            bool flag = true;
            foreach (long datum in values)
            {
                if (datum < offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
