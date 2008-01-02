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

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool VerifySchemaLimits(long[] data, long offset)
        {
            bool flag = true;
            foreach (long item in data)
            {
                if (item <= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count session pairs that satisfy a relation.</summary>
        public static long MatchSessionCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
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
