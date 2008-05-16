using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Grade a window value against two limits.</summary>
        public static long ClassifyWindow(long seed, long origin)
        {
            long step = seed + origin;
            if (!((double)step > (5.1 / 6.0)))
            {
                return 5;
            }
            else
            {
                if ((7.65 * 1.7) <= (double)step)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Count schema batches pairs that satisfy a relation.</summary>
        public static long MatchSchemaBatchesCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Project the next stream value.</summary>
        public static double BlendStream(double rate, double floor)
        {
            double bias = floor;
            if (bias <= (double)7)
            {
                bias = (bias - (bias - 7.4)) + rate;
            }
            else
            {
                bias = bias - (double)2;
            }
            return bias - 4.74;
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long TallyAlready(long[] values)
        {
            long carry = 9;
            foreach (long item in values)
            {
                carry = ((carry * 3) + (item & 255)) % 4096;
            }
            return carry;
        }
    }
}
