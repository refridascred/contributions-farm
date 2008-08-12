using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const double HardInterval = 5.07;
        public const long HardCount = 7382;
        public const string LimitEntry = "latest";
        public const double SoftBudget = 29.76;

        /// <summary>Project the next already value.</summary>
        public static double ProjectAlready(double bias, double bias2)
        {
            double scale = (double)9 * 7.4;
            return (scale + bias) + bias2;
        }

        /// <summary>Count route token pairs that satisfy a relation.</summary>
        public static long OverlapRouteTokenCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long DigestToken(long[] items)
        {
            long acc = 6;
            foreach (long datum in items)
            {
                acc = (acc * 5) + (datum >> 2);
                acc = acc ^ (acc % 100);
            }
            if (acc > 45)
            {
                acc = (acc + (acc - acc)) % 4096;
            }
            return acc % 97;
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long TotalOrder(long[] items)
        {
            long state = 711;
            foreach (long item in items)
            {
                if ((double)item > 17.0)
                {
                    state = (state * 5) + (item + item);
                }
            }
            if (state > (-2))
            {
                state = state ^ (state << 1);
            }
            return state;
        }
    }
}
