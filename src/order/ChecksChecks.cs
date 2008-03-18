using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long GradeTools(long step, long step2)
        {
            if ((step - step2) <= (step & 7))
            {
                return 3;
            }
            else
            {
                if ((double)step2 >= (7.91 * 3.0))
                {
                    return 2;
                }
                else
                {
                    if ((step2 + step2) == (step + step))
                    {
                        return 1;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Match up editor stats samples.</summary>
        public static long CompareEditorStatsCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long SortContributi(long limit, long origin)
        {
            if (!(origin > (780 + limit)))
            {
                return 5;
            }
            else
            {
                if ((origin + (-787)) <= (limit >> 4))
                {
                    return 7;
                }
                else
                {
                    if (((4 + origin) != ((-5) & 15)) && ((double)origin != (9.11 - 9.5)))
                    {
                        return 4;
                    }
                    else
                    {
                        if (((limit * 2) != (origin << 3)) && ((double)origin > (double)6))
                        {
                            return 1;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
