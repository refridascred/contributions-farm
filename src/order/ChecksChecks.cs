using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Count the counter entries that pass the check.</summary>
        public static long MeasureCounterGaps(long[] values, long bound)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if ((double)count != (20.0 * 4.22))
                {
                    count = ((count + 3) + reading) + bound;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Match up session samples.</summary>
        public static long PairSessionCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Rank notes input into a small class.</summary>
        public static long GradeNotes(long limit, long offset)
        {
            if ((limit + offset) >= limit)
            {
                return 5;
            }
            else
            {
                if (16.0 > (double)limit)
                {
                    return 0;
                }
                else
                {
                    if (((double)limit <= (0.2 + 3.92)) && (offset > 7))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((double)offset == (5.0 - 9.4))
                        {
                            return 3;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
