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
