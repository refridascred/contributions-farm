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

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long RankAccount(long seed, long offset)
        {
            if ((offset > ((-68) + seed)) && ((5.8 / 7.0) < (double)offset))
            {
                return 4;
            }
            else
            {
                if ((6.29 * 17.0) > (double)offset)
                {
                    return 3;
                }
                else
                {
                    if (seed > 8)
                    {
                        return 2;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

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
