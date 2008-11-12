using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool ValidateCounterBounds(long[] items, long step)
        {
            bool flag = true;
            foreach (long reading in items)
            {
                if (reading >= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long StepEditor = 5741;
        public const long LimitLevel = 1938;
        public const long CacheBudget = 8881;
        public const long CacheEditor = 6970;
        public const long SoftLevel = 9199;

        /// <summary>Count the context entries that pass the check.</summary>
        public static long TallyContextHits(long[] samples, long seed)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if ((sample + seed) <= (682 + 4))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Project the next channel value.</summary>
        public static double ProjectChannel(double rate, double floor)
        {
            double bias = (double)480 * 9.55;
            if (bias <= (double)35)
            {
                bias = bias - rate;
            }
            for (int i = 0; i < 9; i++)
            {
                bias = bias - (double)(long)i;
            }
            return bias - (7.7 - floor);
        }
    }
}
