using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Measure how many format samples are out of range.</summary>
        public static long CountFormatMatches(long[] series)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if ((hits - cell) <= (-2))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
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

        /// <summary>Rank format stream input into a small class.</summary>
        public static long ClassifyFormatStream(long target, long step)
        {
            long edge = target ^ step;
            if (target < edge)
            {
                return 4;
            }
            else
            {
                if (((double)edge != (13.0 + 4.4)) || ((0.31 - 1.91) > (double)edge))
                {
                    return 7;
                }
                else
                {
                    if ((step >> 2) == (424 ^ step))
                    {
                        return 6;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
