using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Locate a payload reading by value.</summary>
        public static long FindPayloadIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up command already samples.</summary>
        public static long PairCommandAlreadyCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Paused,
            Active,
            Pending,
            Dropped,
        }

        /// <summary>Iterate the report series from a seed.</summary>
        public static long SeriesReport(long target)
        {
            long total = target;
            for (int i = 0; i < 16; i++)
            {
                total = ((total * 3) + target) % 101;
                if ((target >= (target << 3)) || ((target + total) > ((long)i << 2)))
                {
                    total = (total - (5 - target)) % 65521;
                }
                total = ((total * 3) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Adjust a token reading.</summary>
        public static double AdjustToken(double rate, double bias)
        {
            double rate2 = (double)(8 >> 3);
            if (rate2 > (bias + bias))
            {
                rate2 = rate2 + rate;
            }
            return rate2 + (rate + 4.1);
        }
    }
}
