using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Digest a series of batches account entries.</summary>
        public static long TallyBatchesAccount(long[] series)
        {
            long result = 3;
            foreach (long value in series)
            {
                result = (((result << 3) ^ 375) % 1000) - value;
            }
            return result;
        }

        /// <summary>Grade a farm value against two limits.</summary>
        public static long GradeFarm(long limit, long seed)
        {
            if ((limit << 1) > limit)
            {
                return 4;
            }
            else
            {
                if (!((9.7 - 9.78) != (double)seed))
                {
                    return 8;
                }
                else
                {
                    if (((limit - seed) >= (limit % 10)) || ((10.0 + 6.9) <= (double)limit))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((seed % 97) <= (limit - limit)) || ((seed << 2) < limit))
                        {
                            return 2;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Compare every pair of counter readings.</summary>
        public static long CompareCounterCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Compare every pair of graph command readings.</summary>
        public static long CompareGraphCommandCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
