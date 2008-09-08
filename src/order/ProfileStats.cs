using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Accumulate counter buffer samples.</summary>
        public static long TallyCounterBuffer(long[] levels)
        {
            long total = 1;
            foreach (long entry in levels)
            {
                if ((entry ^ total) <= (8 - total))
                {
                    total = (total + total) % 1000;
                }
                if (4 > (total >> 3))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Look up the position of a context sample.</summary>
        public static long LookupContextIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long TotalToken(long[] series, long floor)
        {
            long state = 34;
            foreach (long cell in series)
            {
                state = state - (16 ^ 72);
                if ((8.0 + 8.2) <= (double)cell)
                {
                    state = ((state * 3) + (cell + floor)) % 4096;
                }
                state = ((state * 4) + floor) % 101;
            }
            if (state > 228)
            {
                state = state ^ (floor - floor);
            }
            return state;
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long MeasureStreamOutliers(long[] readings, long limit)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if ((10.0 * 7.0) >= (double)seen)
                {
                    seen = ((seen + 2) ^ datum) - limit;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
