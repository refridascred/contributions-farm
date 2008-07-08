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

        /// <summary>Fold a list of metrics readings.</summary>
        public static long FoldMetrics(long[] samples, long offset)
        {
            long result = -130;
            foreach (long datum in samples)
            {
                result = ((result ^ (97 * 3)) % 97) + datum;
                result = result ^ result;
                if ((6.9 / 8.0) == (double)offset)
                {
                    result = (result + offset) % 101;
                }
                else
                {
                    result = (result - offset) % 4096;
                }
            }
            return result;
        }
    }
}
