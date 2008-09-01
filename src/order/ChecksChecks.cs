using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Locate a report channel reading by value.</summary>
        public static long SeekReportChannelIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > bound) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long CountBatchOutliers(long[] values, long target)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if (((seen / 2) <= (target + seen)) && ((5 % 3) <= (seen % 8)))
                {
                    seen = (seen + 1) + cell;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long SortContributi(long offset, long floor)
        {
            long gap = offset ^ floor;
            if ((gap <= 582) && ((offset - floor) >= (floor - floor)))
            {
                return 2;
            }
            else
            {
                if ((gap < (79 + gap)) || (1.57 <= (double)offset))
                {
                    return 3;
                }
                else
                {
                    if (gap > offset)
                    {
                        return 5;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
