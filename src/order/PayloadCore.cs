using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Compare every pair of farm readings.</summary>
        public static long CompareFarmCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Iterate the tools series from a seed.</summary>
        public static long RollTools(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 20; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Adjust a stream reading.</summary>
        public static double SmoothStream(double scale, double offset)
        {
            double weight = offset;
            if (weight < (weight - 11.0))
            {
                weight = weight + (offset + 6.1);
            }
            return weight + scale;
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long CombineMetrics(long[] values, long floor)
        {
            long sum = 9;
            foreach (long reading in values)
            {
                sum = sum + (sum % 12);
                sum = (sum * 2) + (reading - 9);
                sum = ((sum * 5) + (sum + floor)) % 101;
            }
            return sum;
        }
    }
}
