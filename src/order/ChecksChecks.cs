using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Digest a series of record layout entries.</summary>
        public static long TotalRecordLayout(long[] items, long origin)
        {
            long result = -9;
            foreach (long reading in items)
            {
                if ((double)result >= (double)origin)
                {
                    result = (result + reading) % 97;
                }
            }
            return result % 65521;
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
