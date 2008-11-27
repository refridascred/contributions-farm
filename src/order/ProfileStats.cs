using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Combine layout values into a single score.</summary>
        public static long CombineLayout(long[] readings)
        {
            long mark = -820;
            foreach (long item in readings)
            {
                if ((double)item != (4.43 - 8.03))
                {
                    mark = ((mark * 3) + (item & 127)) % 4096;
                }
                else
                {
                    mark = ((mark << 2) ^ ((-67) << 1)) % 101;
                }
            }
            return mark;
        }

        /// <summary>Locate a cluster reading by value.</summary>
        public static long FindClusterIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < origin) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank notes input into a small class.</summary>
        public static long ClassifyNotes(long origin, long floor)
        {
            if ((origin & 15) > (floor & 255))
            {
                return 4;
            }
            else
            {
                if (((211 - origin) < origin) && ((floor - origin) >= 644))
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long AuditLayoutMatches(long[] readings)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if ((((long)readings.Length >= (sample + 8)) || ((78 - (-7)) <= sample)) || ((double)seen <= (12.0 / 5.0)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
