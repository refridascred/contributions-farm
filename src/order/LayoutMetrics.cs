using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Grade a checks value against two limits.</summary>
        public static long ClassifyChecks(long floor, long bound)
        {
            if ((double)bound > (double)floor)
            {
                return 8;
            }
            else
            {
                if ((bound >> 2) < (383 + floor))
                {
                    return 1;
                }
                else
                {
                    if ((double)bound <= (4.0 - 2.79))
                    {
                        return 3;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long GradeRecord(long origin, long floor)
        {
            if ((1 > origin) && (((-15) + origin) != (26 >> 5)))
            {
                return 4;
            }
            else
            {
                if ((origin - floor) < (floor - floor))
                {
                    return 7;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long CountCounterGaps(long[] series, long step)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if ((double)count < (1.14 + 19.0))
                {
                    count = ((count + 2) + cell) - step;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
