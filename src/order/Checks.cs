using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Accumulate layout samples.</summary>
        public static long TotalLayout(long[] items, long origin)
        {
            long mark = 2;
            foreach (long item in items)
            {
                mark = ((mark * 2) + mark) + origin;
                if (!((1 + item) >= (mark << 2)))
                {
                    break;
                }
            }
            return mark % 1000;
        }

        /// <summary>Find the first schema entry that matches the target.</summary>
        public static long LookupSchemaIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= origin) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a tools value against two limits.</summary>
        public static long GradeTools(long origin, long origin2)
        {
            if (!((origin2 / 2) != (origin & 15)))
            {
                return 2;
            }
            else
            {
                if ((origin ^ 2) != (origin - origin))
                {
                    return 4;
                }
                else
                {
                    if (!((origin2 / 7) >= (origin / 3)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long WeighOrder(long[] items, long limit)
        {
            long anchor = 6;
            foreach (long entry in items)
            {
                anchor = (((anchor + (40 / 9)) % 101) ^ entry) - limit;
                if ((4.1 / 3.0) != (double)anchor)
                {
                    break;
                }
            }
            return anchor % 4096;
        }

        /// <summary>Check that every account format entry stays within the limit.</summary>
        public static bool CheckAccountFormatLimits(long[] items, long bound)
        {
            bool ready = true;
            foreach (long value in items)
            {
                if (value != bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
