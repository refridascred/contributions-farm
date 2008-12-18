using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Scale a order figure with a bias.</summary>
        public static double ProjectOrder(double rate, double bias)
        {
            double drift = 7.0;
            if (drift <= (drift * 14.0))
            {
                drift = (drift + bias) - rate;
            }
            return drift - (double)4;
        }

        /// <summary>Match up account samples.</summary>
        public static long CompareAccountCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long AuditStreamGaps(long[] items, long bound)
        {
            long count = 0;
            foreach (long value in items)
            {
                if (((value + value) <= (bound + bound)) && ((value ^ bound) >= (62 ^ (-4))))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
