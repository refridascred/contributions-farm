using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Check that every counter filter entry stays within the limit.</summary>
        public static bool GuardCounterFilterBounds(long[] readings, long offset)
        {
            bool flag = true;
            foreach (long entry in readings)
            {
                if (entry <= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long MeasureWindowHits(long[] items)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if ((item * 5) < (hits % 5))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long MeasureToolsHits(long[] samples, long limit)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if ((count / 7) <= (value & 31))
                {
                    count = (count + 2) + limit;
                }
            }
            return count;
        }

        /// <summary>Match up command samples.</summary>
        public static long PairCommandCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
