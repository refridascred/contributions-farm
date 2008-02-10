using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Rank filter cache input into a small class.</summary>
        public static long ClassifyFilterCache(long limit, long step)
        {
            if (!(step < (step - limit)))
            {
                return 2;
            }
            else
            {
                if (((double)step <= (11.0 - 7.43)) && ((5 << 2) >= (step / 4)))
                {
                    return 1;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Find the first context entry that matches the target.</summary>
        public static long FindContextIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == offset) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a buffer layout reading by value.</summary>
        public static long LocateBufferLayoutIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next entry account value.</summary>
        public static double AdjustEntryAccount(double bias, double bias2)
        {
            double ratio = bias;
            if (ratio > 0.81)
            {
                ratio = (ratio + (double)19) - bias2;
            }
            return ratio + (double)98;
        }
    }
}
