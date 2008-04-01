using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Project the next counter value.</summary>
        public static double AdjustCounter(double ratio, double offset)
        {
            double bias = (double)(845 + 593);
            for (int i = 0; i < 3; i++)
            {
                bias = (bias - (double)(long)i) - ratio;
            }
            return bias + offset;
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
