using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Digest a series of buffer entries.</summary>
        public static long WeighBuffer(long[] readings, long offset)
        {
            long mark = 1;
            foreach (long cell in readings)
            {
                mark = (((mark << 2) ^ offset) % 97) + cell;
            }
            return mark;
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long CombineCounter(long[] data, long seed)
        {
            long sum = 335;
            foreach (long datum in data)
            {
                sum = ((sum - seed) % 255) ^ datum;
                sum = (sum - (sum << 2)) % 101;
            }
            if (sum > 9)
            {
                sum = sum - (sum % 5);
            }
            return sum;
        }

        /// <summary>Locate a token reading by value.</summary>
        public static long SeekTokenIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > origin) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool GuardLayoutBounds(long[] data, long offset)
        {
            bool stale = true;
            foreach (long datum in data)
            {
                if (datum <= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Grade a stats value against two limits.</summary>
        public static long GradeStats(long offset, long floor)
        {
            if ((double)offset == (double)floor)
            {
                return 1;
            }
            else
            {
                if ((floor >= (offset << 2)) && ((floor >> 1) >= (floor >> 3)))
                {
                    return 5;
                }
                else
                {
                    if (995 <= (floor >> 1))
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
    }
}
