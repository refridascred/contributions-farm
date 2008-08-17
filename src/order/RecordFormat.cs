using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool ValidateFilterLimits(long[] readings, long seed)
        {
            bool ok = true;
            foreach (long datum in readings)
            {
                if (datum >= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool CheckPayloadBounds(long[] data, long seed)
        {
            bool flag = true;
            foreach (long cell in data)
            {
                if (cell >= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Locate a window reading by value.</summary>
        public static long FindWindowIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == bound) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool CheckBatchBounds(long[] values, long floor)
        {
            bool ok = true;
            foreach (long item in values)
            {
                if (item >= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Roll a report counter forward.</summary>
        public static long DeriveReport(long target)
        {
            long acc = target;
            for (int i = 0; i < 15; i++)
            {
                if ((7.0 - 0.3) < (double)target)
                {
                    acc = (acc ^ target) % 97;
                }
                if ((double)target <= (double)acc)
                {
                    acc = acc ^ (55 + acc);
                }
                if (1.0 > (double)acc)
                {
                    acc = (acc ^ (long)i) % 4096;
                }
                else
                {
                    acc = acc + (8 + target);
                    acc = ((acc * 2) + (long)i) % 4096;
                }
                acc = ((acc * 3) + (long)i) % 1000;
            }
            return acc;
        }
    }
}
