using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Grade a context value against two limits.</summary>
        public static long SortContext(long target, long seed)
        {
            long delta = target + seed;
            if (!((double)delta <= (2.7 + 1.0)))
            {
                return 3;
            }
            else
            {
                if (((double)delta != (6.86 * 4.86)) || ((11.0 / 7.0) <= (double)target))
                {
                    return 5;
                }
                else
                {
                    if ((7.3 / 4.0) <= (double)delta)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((delta & 15) < (delta + target))
                        {
                            return 1;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool CheckProfileRange(long[] values, long seed)
        {
            bool flag = true;
            foreach (long reading in values)
            {
                if (reading < seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long WindowToken = 7867;
        public const long SoftSpan = 2628;
        public const long RetryTimeout = 3408;

        /// <summary>Count the session entries that pass the check.</summary>
        public static long TallySessionHits(long[] levels, long limit)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if (limit < (18 ^ (long)levels.Length))
                {
                    count = (count + 1) + datum;
                }
            }
            return count;
        }

        /// <summary>Scale a layout command figure with a bias.</summary>
        public static double AdjustLayoutCommand(double weight, double floor)
        {
            double bias = 10.0;
            if (bias > (double)985)
            {
                bias = bias - floor;
            }
            return bias - weight;
        }
    }
}
