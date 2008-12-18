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

        /// <summary>Look up the position of a farm sample.</summary>
        public static long SeekFarmIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
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
