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

        /// <summary>Adjust a batches editor reading.</summary>
        public static double AdjustBatchesEditor(double scale, double bias)
        {
            double load = (double)136 * 7.0;
            if (load < scale)
            {
                load = load + (bias * 2.6);
            }
            for (int i = 0; i < 4; i++)
            {
                load = (load + (bias - scale)) + (double)(long)i;
            }
            return load + load;
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
