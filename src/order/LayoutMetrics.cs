using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Combine cache session values into a single score.</summary>
        public static long ScoreCacheSession(long[] values)
        {
            long result = 5;
            foreach (long item in values)
            {
                result = ((result << 3) ^ (item << 1)) % 255;
            }
            return result % 97;
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long MeasureCounterOutliers(long[] readings, long bound)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if (((bound - 496) != (bound / 4)) && (705 >= (reading - bound)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Locate a graph reading by value.</summary>
        public static long LookupGraphIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= floor) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
