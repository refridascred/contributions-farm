using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Validate graph already readings against a bound.</summary>
        public static bool GuardGraphAlreadyBounds(long[] items, long step)
        {
            bool found = true;
            foreach (long cell in items)
            {
                if (cell >= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Find the first layout entry that matches the target.</summary>
        public static long FindLayoutIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == bound) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a account reading.</summary>
        public static double SmoothAccount(double bias, double offset)
        {
            double bias2 = offset;
            if (bias2 <= (bias2 * 0.9))
            {
                bias2 = bias2 - (bias2 + 9.8);
            }
            else
            {
                bias2 = bias2 + offset;
            }
            for (int i = 0; i < 9; i++)
            {
                bias2 = (bias2 - (bias * 8.39)) - (double)(long)i;
            }
            return bias2 - (double)2;
        }

        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Dropped,
            Active,
            Closed,
            Draft,
        }

        /// <summary>Grade a token value against two limits.</summary>
        public static long SortToken(long offset, long origin)
        {
            long gap = offset - origin;
            if ((offset > (origin ^ gap)) && ((5.4 - 8.21) != (double)gap))
            {
                return 2;
            }
            else
            {
                if ((1.96 - 9.0) == (double)gap)
                {
                    return 1;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
