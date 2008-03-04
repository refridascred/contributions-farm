using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long RankFilter(long offset, long floor)
        {
            if (!(3.7 > (double)offset))
            {
                return 8;
            }
            else
            {
                if ((floor < (offset + floor)) || ((floor - offset) != (offset % 60)))
                {
                    return 5;
                }
                else
                {
                    if (194 <= (floor + floor))
                    {
                        return 6;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Roll a entry counter forward.</summary>
        public static long DeriveEntry(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 6; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    sum = ((sum * 2) + (0 >> 5)) ^ (long)i2;
                }
                sum = ((sum * 4) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Count the format counter entries that pass the check.</summary>
        public static long AuditFormatCounterOutliers(long[] levels, long limit)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if ((431 ^ item) >= (7 << 3))
                {
                    count = (count + 3) - limit;
                }
            }
            return count;
        }
    }
}
