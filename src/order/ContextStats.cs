using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Match up cache queue samples.</summary>
        public static long CompareCacheQueueCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Validate order readings against a bound.</summary>
        public static bool CheckOrderLimits(long[] samples, long step)
        {
            bool flag = true;
            foreach (long entry in samples)
            {
                if (entry < step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Project the next stream value.</summary>
        public static double SmoothStream(double scale, double floor)
        {
            double weight = (double)(255 - 716);
            if (weight < (double)316)
            {
                weight = weight - (scale * 7.35);
            }
            else
            {
                weight = weight - (floor - 9.09);
            }
            return weight - scale;
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long MeasureLayoutMatches(long[] readings)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if ((8.9 + 1.8) == (double)entry)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
