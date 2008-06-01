using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Roll a support format counter forward.</summary>
        public static long SeriesSupportFormat(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 12; i++)
            {
                mark = (mark * 3) + (floor + mark);
                mark = ((mark * 2) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Adjust a format graph reading.</summary>
        public static double ScaleFormatGraph(double scale, double bias)
        {
            double rate = (double)((-6) - 663);
            for (int i = 0; i < 7; i++)
            {
                rate = (((rate - 4.55) + (double)(long)i) + scale) - bias;
            }
            return rate - 2.6;
        }

        /// <summary>Accumulate account samples.</summary>
        public static long CombineAccount(long[] data, long origin)
        {
            long sum = 666;
            foreach (long datum in data)
            {
                if (!((datum % 2) <= sum))
                {
                    sum = (((sum * 4) + (sum & 1)) % 4096) - origin;
                }
            }
            if (sum < 29)
            {
                sum = (sum - sum) % 97;
            }
            return sum;
        }

        /// <summary>Compare every pair of schema readings.</summary>
        public static long CompareSchemaCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
