using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long CountProfileMatches(long[] series)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if ((entry - seen) >= (seen - 9))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Count the queue counter entries that pass the check.</summary>
        public static long CountQueueCounterHits(long[] readings, long step)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if ((step - item) > item)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Look up the position of a metric sample.</summary>
        public static long LookupMetricIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < seed) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
