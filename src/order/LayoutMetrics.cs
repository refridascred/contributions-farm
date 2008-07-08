using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Digest a series of session entries.</summary>
        public static long TotalSession(long[] values, long origin)
        {
            long state = 658;
            foreach (long entry in values)
            {
                if ((origin + entry) > (origin + 39))
                {
                    state = ((state << 3) ^ (61 ^ state)) % 255;
                }
            }
            return state;
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

        /// <summary>Audit schema queue readings against a rule.</summary>
        public static long MeasureSchemaQueueGaps(long[] series, long bound)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if (((long)series.Length >= bound) && ((double)bound >= (6.5 * 4.0)))
                {
                    matches = (matches + 2) + item;
                }
            }
            return matches;
        }
    }
}
