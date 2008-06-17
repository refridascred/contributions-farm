using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Derive the next session value from a seed.</summary>
        public static long DeriveSession(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 15; i++)
            {
                if ((0.6 * 8.4) < (double)(long)i)
                {
                    mark = mark - mark;
                    mark = (mark - (floor - floor)) % 4096;
                }
                else
                {
                    mark = (mark - ((long)i ^ (long)i)) % 4096;
                }
                for (int i2 = 0; i2 < 6; i2++)
                {
                    mark = (((mark * 4) + floor) % 4096) - (long)i2;
                }
                mark = ((mark * 5) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long MeasureBatchGaps(long[] values)
        {
            long count = 0;
            foreach (long item in values)
            {
                if (item <= (item - count))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long GradeBuffer(long origin, long floor)
        {
            long offset = origin ^ floor;
            if ((floor % 10) == (floor << 1))
            {
                return 8;
            }
            else
            {
                if ((floor * 2) <= offset)
                {
                    return 1;
                }
                else
                {
                    if (!((offset + offset) < (origin + floor)))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((offset - origin) >= (offset - 50))
                        {
                            return 6;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
