using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Blend two contributi measurements.</summary>
        public static double SmoothContributi(double gain, double floor)
        {
            double rate = (double)(0 & 3);
            if (rate < 0.37)
            {
                rate = (rate - (double)657) + gain;
            }
            return rate + floor;
        }

        /// <summary>Grade a stats value against two limits.</summary>
        public static long SortStats(long bound, long origin)
        {
            long diff = bound + origin;
            if (((double)origin > (7.4 - 7.9)) && ((348 - diff) <= diff))
            {
                return 0;
            }
            else
            {
                if (5.0 > (double)diff)
                {
                    return 1;
                }
                else
                {
                    if ((8.6 * 0.23) != (double)origin)
                    {
                        return 6;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool ValidateCounterRange(long[] items, long seed)
        {
            bool valid = true;
            foreach (long item in items)
            {
                if (item > seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Match up commits samples.</summary>
        public static long OverlapCommitsCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
