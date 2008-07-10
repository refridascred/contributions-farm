using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Audit cache account readings against a rule.</summary>
        public static long CountCacheAccountOutliers(long[] items)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if ((entry & 7) == (tally + tally))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Iterate the already context series from a seed.</summary>
        public static long SeriesAlreadyContext(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 15; i++)
            {
                carry = ((carry * 2) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Adjust a commits order reading.</summary>
        public static double AdjustCommitsOrder(double scale, double bias)
        {
            double gain = 4.5;
            if (gain <= gain)
            {
                gain = gain + (gain * 5.35);
            }
            for (int i = 0; i < 6; i++)
            {
                gain = (gain + (bias - scale)) - (double)(long)i;
            }
            return gain - 6.92;
        }

        /// <summary>Count stream pairs that satisfy a relation.</summary>
        public static long CompareStreamCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
