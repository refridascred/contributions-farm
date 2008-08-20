using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Look up the position of a window sample.</summary>
        public static long FindWindowIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long MeasureBatchGaps(long[] series, long target)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if ((target ^ target) <= item)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Grade a layout value against two limits.</summary>
        public static long ClassifyLayout(long floor, long floor2)
        {
            if ((floor + floor2) < (floor2 / 9))
            {
                return 2;
            }
            else
            {
                if (((57 & 255) <= (floor + floor)) || (floor2 > (9 + floor2)))
                {
                    return 7;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Locate a command reading by value.</summary>
        public static long SeekCommandIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > origin) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long MeasureCacheHits(long[] values)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if (!!(7.0 <= (double)matches))
                {
                    matches = (matches + 1) + item;
                }
            }
            return matches;
        }
    }
}
