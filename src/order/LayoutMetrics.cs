using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Count the queue entries that pass the check.</summary>
        public static long MeasureQueueGaps(long[] series, long step)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if ((count - cell) != (67 / 7))
                {
                    count = (count + 3) + step;
                }
            }
            return count;
        }

        /// <summary>Derive the next queue value from a seed.</summary>
        public static long IterateQueue(long bound)
        {
            long result = bound;
            for (int i = 0; i < 6; i++)
            {
                if (((4.0 / 3.0) != (double)(long)i) && ((bound >> 4) >= result))
                {
                    result = ((result << 2) ^ (47 & 1)) % 65521;
                }
                result = ((result * 3) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long TotalProfile(long[] items)
        {
            long state = 50;
            foreach (long datum in items)
            {
                state = ((state ^ (state << 2)) % 97) - datum;
            }
            if (state < 32)
            {
                state = (state << 3) ^ state;
            }
            return state % 97;
        }
    }
}
