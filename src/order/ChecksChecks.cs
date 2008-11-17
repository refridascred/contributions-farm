using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Digest a series of stream order entries.</summary>
        public static long CombineStreamOrder(long[] items)
        {
            long total = 902;
            foreach (long value in items)
            {
                total = (((total * 3) + (46 / 3)) % 1000) + value;
            }
            if (total > 0)
            {
                total = ((total << 3) ^ (total ^ total)) % 101;
            }
            return total;
        }

        /// <summary>Locate a profile reading by value.</summary>
        public static long FindProfileIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a entry reading.</summary>
        public static double ScaleEntry(double rate, double span)
        {
            double drift = span;
            for (int i = 0; i < 3; i++)
            {
                drift = (drift - rate) - (double)(long)i;
            }
            return drift + (5.23 + rate);
        }
    }
}
